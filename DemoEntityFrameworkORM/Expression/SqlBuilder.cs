using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class SqlBuilder : ExpressionVisitor
    {
        internal static object ModelAssemblyName = "Models";
        ExpressionVisitorSqlSelect selectVisitor = new ExpressionVisitorSqlSelect();
        ExpressionVisitorSqlWhere whereVisitor = new ExpressionVisitorSqlWhere();
        ExpressionVisitorSqlTablesFrom fromVisitor = new ExpressionVisitorSqlTablesFrom();
        List<List<MemberInfo>> memberInfoLists = new List<List<MemberInfo>>();
        string _FromString;
        public string Sql 
        { 
            get 
            {
                return selectVisitor.SqlSelect + _FromString + whereVisitor.SqlWhere;
            } 
        }
        public string GetSql<T>(Expression<Func<IQueryable<T>, object>> expression)
        {
            Visit(expression);
            //finish all the visiting , get the from sql string
            StringBuilder sb = new StringBuilder();
            sb.Append($" FROM {typeof(T).Name}");
            foreach (List<MemberInfo> memberInfos in memberInfoLists)
            {
                for (int i = 0; i < memberInfos.Count; i++)
                {
                    MemberInfo info = memberInfos[i];
                    string leftTable = i == 0 ? typeof(T).Name : memberInfos[i - 1].Name;
                    string rightTable = info.Name;
                    string foreignKey = (info.GetCustomAttribute(typeof(ForeignKeyAttribute)) as ForeignKeyAttribute).Name;
                    sb.Append(string.Format(" LEFT JOIN {0} ON {0}.{1} = {2}.{1}", rightTable, foreignKey, leftTable));
                }
            }
            _FromString = sb.ToString();
            return Sql;
        }

        /// <summary>
        /// Visit是个入口，解读node表示式
        /// 根据表达式的类型，将表达式调度到此类中更专用的访问方法之一的表达式
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public override Expression Visit(Expression node)
        {
            if (node == null)
                return null;
            return base.Visit(node);
        }
        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            Visit(node.Body);
            foreach (var parameter in node.Parameters)
            {
                Visit(parameter);
            }
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            fromVisitor.VisitFromExpression(node);
            if (memberInfoLists.Count==0)
                memberInfoLists.Add(fromVisitor.memberInfoStack.ToList());
            else
            {
                List<MemberInfo> memberinfoList = fromVisitor.memberInfoStack.ToList();
                if (memberinfoList.Count == 0)
                    return node;
                List<MemberInfo> newMemberInfoList = new List<MemberInfo>();
                for (int ii = 0; ii < memberinfoList.Count; ii++)
                {
                    bool IsExists = false;
                    for (int i = 0; i < memberInfoLists.Count; i++)
                    {
                        if (memberInfoLists[i][ii] == memberinfoList[ii])
                        {
                            IsExists = true;
                            break;
                        }
                    }
                    if(!IsExists)
                        newMemberInfoList.Add(memberinfoList[ii]);
                }
                if(newMemberInfoList.Count>0)
                    memberInfoLists.Add(newMemberInfoList);
            }
            return node;
        }
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            foreach (var arg in node.Arguments)
            {
                Visit(arg);
            }
            if (node.Object != null)
            {
                Visit(node.Object);
            }
            switch (node.Method.Name)
            {
                case "Where":
                    whereVisitor.Visit(node.Arguments[1]); break;//Visit Where Lambda
                case "Select":
                    selectVisitor.Visit(node.Arguments[1]); break;//Visit Select lambda
                default:
                    break;
            }
            return node;
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
            return node;
        }
    }

}
