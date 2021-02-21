using System;
using System.Globalization;
using System.Windows.Data;

namespace ReflectionEditDialog.Infrastructure.Converters.Base
{
    internal abstract class Converter : IValueConverter
    {
        public object Convert(object v, Type t, object p, CultureInfo c) => Convert(v);

        public object ConvertBack(object v, Type t, object p, CultureInfo c) => ConvertBack(v);

        protected abstract object Convert(object v);

        protected virtual object ConvertBack(object v) => throw new NotSupportedException();
    }
}
