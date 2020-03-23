using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
 
    /// <summary>
    /// 泛型代表主表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExpressionVisitorSqlSelect: ExpressionVisitor
    {
        private List<string> _ColumnList = new List<string>();
        public List<PropertyInfo> PropertyInfoArray = new List<PropertyInfo>();
        public string SqlSelect 
        {
            get { return "SELECT " + string.Join(",",this._ColumnList.ToArray()); }
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
            if (node == null)
                return node;
            _ColumnList.Add(node.Member.DeclaringType.Name + "." + node.Member.Name);
            Type type = Type.GetType($"{StaticConstant.ModelAssemblyName}.{node.Member.DeclaringType.Name},{StaticConstant.ModelAssemblyName}", true);
            PropertyInfoArray.Add(type.GetProperty(node.Member.Name));
            return node;
        }

        protected override Expression VisitNew(NewExpression node)
        {
            foreach (var arg in node.Arguments)
            {
                Visit(arg);
            }
            return node;
        }
    }
}
