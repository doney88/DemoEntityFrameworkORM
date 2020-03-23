using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ExpressionVisitorSqlOrderBy:ExpressionVisitor
    {
        StringBuilder stringBuilder = new StringBuilder();

        public string SqlOrderBy
        {
            get{ return " ORDER BY " + stringBuilder.ToString().Substring(1); }
        }

        public void OrderByVisit(Expression node, EnumOrderByDirection orderByDirection = EnumOrderByDirection.eAscending)
        {
            Visit (node);
            if (orderByDirection == EnumOrderByDirection.eAscending)
                stringBuilder.Append(" ASC");
            else
                stringBuilder.Append(" DESC");

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

        protected override Expression VisitMember(MemberExpression node)
        {
            stringBuilder.Append($",[{node.Member.DeclaringType.Name}].[{node.Member.Name}]");
            return node;
        }

        public enum EnumOrderByDirection
        {
            eAscending = 0,
            eDescending = 1
        }
    }
}
