using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DatabaseUpdate.Helper
{
    public static class ReflectionHelper
    {
        public static string GetDisplayName(PropertyInfo property)
        {
          DisplayNameAttribute aa = property.GetCustomAttribute<DisplayNameAttribute>();
          return aa.DisplayName;
//            return (TypeDescriptor.GetProperties(modelType)[propertyName]
//                                  .Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute)?.DisplayName;
        }

        public static string GetDisplay(Type modelType, string propertyDisplayName)
        {
            return (TypeDescriptor.GetProperties(modelType)[propertyDisplayName].Attributes[typeof(DisplayAttribute)] as
                            DisplayAttribute)?.Name;
        }
    }
}