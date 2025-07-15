using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvert
{
    [TypeConverter(typeof(StringToHumanTypeConverter))]
    public class Human
    {
        public string? Name { get; set; }

        public Human Child { get; set; }
    }

    public class StringToHumanTypeConverter: TypeConverter
    {
        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
        {
            if (value is string && value != null)
            {
                Human h = new Human();
                h.Name = value?.ToString();
                return h;
            }
            return base.ConvertFrom(context, culture, value);
        }


    }
}
