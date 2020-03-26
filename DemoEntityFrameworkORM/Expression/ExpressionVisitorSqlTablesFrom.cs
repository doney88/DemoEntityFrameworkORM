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
    public class ExpressionVisitorSqlTablesFrom: ExpressionVisitor
    {
        Stack<MemberInfo> memberinfoStack = new Stack<MemberInfo>();

        public override Expression Visit(Expression node)
        {
            if (node == null)
                return null;
            return base.Visit(node);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            
            if(node.Member.IsDefined(typeof(ForeignKeyAttribute)))  //use namespace to identify entity class
            {
                memberinfoStack.Push(node.Member);
            }
            Visit(node.Expression);

            return node;
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            Visit(node.Body);
            memberinfoStack.Push(node.Parameters[0].Type);
            
            return node;
        }
    }
}
