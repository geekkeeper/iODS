using System;

namespace DatabaseUpdate.Annotation.Field
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property,AllowMultiple = true,Inherited = false)]
    public class UpdateFieldAttribute:Attribute
    {
        public UpdateFieldAttribute(string version)
        {
            this.Version = version;
        }

        /// <summary>
        /// 版本信息
        /// </summary>
        public string Version { get; }
    }
}