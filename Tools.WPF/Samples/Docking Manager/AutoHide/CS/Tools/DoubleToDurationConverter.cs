using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;

namespace AutoHideDemo
{
    [ValueConversion( typeof( double ), typeof( Duration ) )]
    public class DoubleToDurationConverter : IValueConverter
    {
        #region IValueConverter Members
        public Object Convert( Object value, Type targetType, Object parameter, CultureInfo culture )
        {
            double seconds = (Double)value;
            return new Duration( TimeSpan.FromSeconds( seconds ) );
        }
        /// <summary>
        /// This method does nothing.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public Object ConvertBack( Object value, Type targetType, Object parameter, CultureInfo culture )
        {
            throw new Exception( "The method or operation is not implemented." );
        }
        #endregion
    }
}
