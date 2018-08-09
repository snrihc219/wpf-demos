﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;

namespace EXCEL.Converters
{
    public class HorizontalAlignmentToCenterAlignConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null && (HorizontalAlignment)value == HorizontalAlignment.Center)
                return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return HorizontalAlignment.Center;
        }
    }
}
