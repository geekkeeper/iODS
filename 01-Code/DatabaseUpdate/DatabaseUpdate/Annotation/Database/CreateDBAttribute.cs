using System;

namespace DatabaseUpdate.Annotation.Database
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true,Inherited = false)]
    public class CreateDBAttribute:Attribute
    {
        
    }
}