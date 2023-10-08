using System;
using System.Collections.Generic;
using System.Text;

namespace SqlHelper.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreAttribute : Attribute
    {
    }
}
