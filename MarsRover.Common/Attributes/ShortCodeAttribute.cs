using System;

namespace MarsRover.Common.Attributes
{
    public class ShortCodeAttribute : Attribute
    {
        public ShortCodeAttribute(string shortCode)
        {
            this.ShortCode = shortCode;
        }

        public ShortCodeAttribute()
        {
        }

        public string ShortCode { get; set; }
    }
}
