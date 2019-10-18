using System;

namespace DatabaseUpdate.Annotation.Table
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true,Inherited = false)]
    public class CreateTableAttribute:Attribute
    {
        public CreateTableAttribute(string version)
        {
            this.Version = version;
        }

        /// <summary>
        /// 版本信息
        /// </summary>
        public string Version { get; }
    }
}