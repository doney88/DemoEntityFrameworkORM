using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class SqlBuilder : ExpressionVisitor
    {
        internal static object ModelAssemblyName = "Models";
        ExpressionVisitorSqlSelect selectVisitor = new ExpressionVisitorSqlSelect();
        ExpressionVisitorSqlWhere whereVisitor = new ExpressionVisitorSqlWhere();
        public string Sql { get; set; }
        public string GetSql<T>(Expression<Func<IQueryable<T>, object>> expression)
        {
            Visit(expression);
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
            return node;
        }
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            foreach (var arg in node.Arguments)
            {
                Visit(arg);
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
    }

}
