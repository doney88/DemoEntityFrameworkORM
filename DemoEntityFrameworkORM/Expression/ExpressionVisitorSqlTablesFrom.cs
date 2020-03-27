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
        public Stack<MemberInfo> memberInfoStack = new Stack<MemberInfo>();

        public void VisitFromExpression(Expression expression)
        {
            memberInfoStack.Clear();        //clear stack at begining of visiting
            Visit(expression);
        }
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
                memberInfoStack.Push(node.Member);
            }
            return Visit(node.Expression);
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            Visit(node.Body);
            memberInfoStack.Push(node.Parameters[0].Type);
            
            return node;
        }
    }
}
