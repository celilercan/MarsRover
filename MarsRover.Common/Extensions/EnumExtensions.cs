using MarsRover.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Common.Extensions
{
    public static class EnumExtensions
    {
        public static string GetShortCode(this Enum val)
        {
            var shortCodeAttr = GetAttributeOfType<ShortCodeAttribute>(val);

            return shortCodeAttr?.ShortCode ?? val.ToString();
        }

        public static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            if (memInfo.Length <= 0) return null;
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes.FirstOrDefault();
        }
    }
}
