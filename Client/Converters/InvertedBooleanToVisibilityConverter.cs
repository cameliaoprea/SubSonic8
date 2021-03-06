﻿namespace Subsonic8.Converters
{
    using System;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Data;

    public class InvertedBooleanToVisibilityConverter : IValueConverter
    {
        #region Public Methods and Operators

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var flag = false;
            if (value is bool)
            {
                flag = (bool)value;
            }

            if (parameter != null)
            {
                if (bool.Parse((string)parameter))
                {
                    flag = !flag;
                }
            }

            return flag ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var back = (value is Visibility) && (((Visibility)value) == Visibility.Visible);
            if (parameter != null)
            {
                if ((bool)parameter)
                {
                    back = !back;
                }
            }

            return back;
        }

        #endregion
    }
}