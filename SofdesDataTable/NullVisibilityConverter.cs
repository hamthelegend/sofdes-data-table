using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace SofdesDataTable
{
    public class NullVisibilityConverter: IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType,
            object parameter, string language)
        {
            if (value != null)
            {
                return Visibility.Visible;
            } else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
