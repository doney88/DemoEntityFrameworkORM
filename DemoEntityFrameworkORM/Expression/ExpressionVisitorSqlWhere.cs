using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ExpressionVisitorSqlWhere:ExpressionVisitor
    {
        Stack<string> _StringStack = new Stack<string>();

        public string SqlWhere
        {
            get{ return " WHERE " +  _StringStack.ToArray()[0];}
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
                return node;
            if (node.NodeType == ExpressionType.Not)
            {
                Expression expression =  base.Visit(node);
                string condition = _StringStack.Pop();
                _StringStack.Push($"NOT({condition})");
                return expression;
            }
            return base.Visit(node);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            _StringStack.Push($"[{node.Member.DeclaringType.Name}].[{node.Member.Name}]");
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            string constant = null;
            switch (node.Type.Name)
            {
                case "Int32":
                    constant = node.Value.ToString();
                    break;
                case "String":
                    constant = $"'{node.Value}'";
                    break;
                default:
                    break;
            }
            _StringStack.Push(constant);
            return node;
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            var right = node.Right;
            var left = node.Left;
            string format = null;
            switch (node.NodeType)
            {
                case ExpressionType.AndAlso:
                    format = "({0} AND {1})";
                    break;
                case ExpressionType.OrElse:
                    format = "({0} OR {1})";
                    break;
                default:
                    break;
            }
            Visit(right);
            Visit(left);
            string l = _StringStack.Pop();
            string r = _StringStack.Pop();
            _StringStack.Push(string.Format(format, new string[] { l, r }));
            return node;
        }
        
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            string format=null;
            switch (node.Method.Name)
            {
                case "Equals":
                    format = "({0} = {1})";break;
                default:
                    break;
            }
            Visit(node.Object);
            Visit(node.Arguments[0]);
            string right = _StringStack.Pop();
            string left = _StringStack.Pop();
            _StringStack.Push(string.Format(format, new string[] { left, right }));
            return node;
        }
        #region 测试目录树Overrid路径

        //protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        //{
        //    return base.Visit(node);
        //}

        //protected override ElementInit VisitElementInit(ElementInit node)
        //{
        //    return node;
        //}
        //protected override LabelTarget VisitLabelTarget(LabelTarget node)
        //{
        //    return node;
        //}
        //protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        //{
        //    return node;
        //}
        //protected override MemberBinding VisitMemberBinding(MemberBinding node)
        //{
        //    return node;
        //}
        //protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        //{
        //    return node;
        //}
        //protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        //{
        //    return node;
        //}
        //protected override SwitchCase VisitSwitchCase(SwitchCase node)
        //{
        //    return node;
        //}
        //protected override Expression VisitBlock(BlockExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitConditional(ConditionalExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitDebugInfo(DebugInfoExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitDefault(DefaultExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitDynamic(DynamicExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitExtension(Expression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitGoto(GotoExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitIndex(IndexExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitInvocation(InvocationExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitLabel(LabelExpression node)
        //{
        //    return node;
        //}
        ////protected override Expression VisitLambda<T>(Expression<T> node)
        ////{
        ////    return node;
        ////}
        //protected override Expression VisitListInit(ListInitExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitLoop(LoopExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitMemberInit(MemberInitExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitNew(NewExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitNewArray(NewArrayExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitParameter(ParameterExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitSwitch(SwitchExpression node)
        //{
        //    return node;
        //}
        //protected override Expression VisitTry(TryExpression node)
        //{
        //    return node;
        //}
        ////protected override Expression VisitUnary(UnaryExpression node)
        ////{
        ////    return node;
        ////}
        #endregion
    }
}
