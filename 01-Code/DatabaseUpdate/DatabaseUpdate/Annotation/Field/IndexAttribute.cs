using System;

namespace DatabaseUpdate.Annotation.Field
{
    /// <summary>
    /// 索引特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class IndexAttribute:Attribute
    {
        public IndexAttribute(string indexName)
        {
            this.IndexName = indexName;
        }

        public IndexAttribute(string indexName, string columnName)
        {
            this.IndexName = indexName;
            this.ColumnName = columnName;
        }

        public string IndexName { get; }
        public string ColumnName { get; }
        
    }
}