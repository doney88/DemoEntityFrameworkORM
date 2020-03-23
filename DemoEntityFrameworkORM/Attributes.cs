using System;

namespace DemoEntityFrameworkORM
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyTableAttribute : Attribute
    {
        public string TableName { get; }

        public MyTableAttribute(string tableName)
        {
            TableName = tableName;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MyKeyAttribute : Attribute
    {
        public bool IsIncrement { get; set; } = true;

        public string FieldName { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MyColumnAttribute : Attribute
    {
        public string ColumnName { get; set; }

        public bool Ignore { get; set; }

        public bool InsertIgnore { get; set; }

        public bool UpdateIgnore { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MyForeignKeyAttribute : Attribute
    {
        public string ForeignKey { get; set; }

        public string MasterKey { get; set; } = "Id";

        public MyForeignKeyAttribute(string foreignKey)
        {
            ForeignKey = foreignKey;
        }
    }
}