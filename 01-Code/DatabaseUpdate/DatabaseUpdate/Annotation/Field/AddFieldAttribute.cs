using System;

namespace DatabaseUpdate.Annotation.Field
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property,AllowMultiple = true,Inherited = false)]
    public class AddFieldAttribute:Attribute
    {
        public AddFieldAttribute(string version)
        {
            this.Version = version;
        }

        /// <summary>
        /// 版本信息
        /// </summary>
        public string Version { get; }
    }
}