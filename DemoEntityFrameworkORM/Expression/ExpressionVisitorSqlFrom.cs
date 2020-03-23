using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ExpressionVisitorSqlFrom : ExpressionVisitor
    {
        private Stack<string> _StringStack = new Stack<string>();
        public string SqlFrom
        {
            get
            {
                string[] stringArray = _StringStack.ToArray();
                StringBuilder stringBuilder = new StringBuilder();
                int indexLeft = stringArray[0].IndexOf("[");
                int indexRight = stringArray[0].IndexOf("].[");
                string table = stringArray[0].Substring(indexLeft, indexRight - indexLeft + 1);
                stringBuilder.Append($" FROM {table}");
                for (int i = 0; i < stringArray.Length; i++)
                {
                    indexLeft = stringArray[i].LastIndexOf("] = [");
                    indexRight = stringArray[i].LastIndexOf("].[");
                    table = stringArray[i].Substring(indexLeft + 4, indexRight - indexLeft - 3);
                    stringBuilder.Append($" LEFT JOIN {table} ON {stringArray[i]}");
                }
                return stringBuilder.ToString();
            }
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

        protected override Expression VisitBinary(BinaryExpression node)
        {
            var right = node.Right;
            var left = node.Left;

            Visit(right);
            Visit(left);
            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            string format = "{0} = {1}";
            Visit(node.Object);
            Visit(node.Arguments[0]);
            string right = _StringStack.Pop();
            string left = _StringStack.Pop();
            _StringStack.Push(string.Format(format, new string[] { left, right }));
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            _StringStack.Push($"[{node.Member.DeclaringType.Name}].[{node.Member.Name}]");
            return node;
        }
    }
}
