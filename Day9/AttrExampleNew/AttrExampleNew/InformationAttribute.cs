using System;

namespace AttrExampleNew
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method |
            AttributeTargets.Constructor, AllowMultiple = true)]
    public class InformationAttribute : Attribute
    {
        public string InformationString { get; set; }
    }
}