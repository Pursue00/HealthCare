using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace HealthCare.Common.ValueConverter
{
    public sealed class BooleanToVisibilityParamConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool flag = false;
            if (value is bool)
            {
                flag = (bool)value;
            }
            else
            {
                if (value is bool?)
                {
                    bool? flag2 = (bool?)value;
                    flag = (flag2.HasValue && flag2.Value);
                }
            }
            if (parameter == null)
                return flag ? ColorTranslator.FromHtml("#c3c3c3") : ColorTranslator.FromHtml("#F0F6FC");
            else
                return flag ? ColorTranslator.FromHtml("#F0F6FC") : ColorTranslator.FromHtml("#c3c3c3");

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return "";
        }
    }
}
