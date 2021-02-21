using System;
using ReflectionEditDialog.Infrastructure.Converters.Base;

namespace ReflectionEditDialog.Infrastructure.Converters
{
    internal class DateTimeToAgeConverter : Converter
    {
        protected override object Convert(object v)
        {
            if (v is null) return null;
            var time = v as DateTime? ?? System.Convert.ToDateTime(v);
            return (int)Math.Ceiling((DateTime.Now - time).TotalDays / 365);
        }

        protected override object ConvertBack(object v)
        {
            if (v is null) return null;
            var age = v as int? ?? System.Convert.ToInt32(v);

            return DateTime.Now.Date.AddYears(-age);
        }
    }
}
