using System;
using System.Globalization;
using MvvmCross.Converters;

namespace Anufrieva.Marria.iOS.Converters
{
    public sealed class DateTimeConverter : MvxValueConverter<DateTime, string>
    {
        protected override string Convert(DateTime value, Type targetType, object parameter, CultureInfo culture) =>
            value.Date.ToString("dd/mm/yyyy");
    }
}