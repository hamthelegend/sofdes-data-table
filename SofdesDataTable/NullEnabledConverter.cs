using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace SofdesDataTable
{
    public class NullEnabledConverter: IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType,
            object parameter, string language)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
