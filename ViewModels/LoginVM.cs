using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redsix.ViewModels
{
    internal class LoginVM
    {
        public object ShowPasswordSwitch { get; private set; }

        //private void ShowPasswordSwitch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    ShowPasswordSwitch.Text = e.Value ? "Hide password" : "Show password";
        //}

        public class InvertedBoolConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is bool boolValue)
                {
                    return !boolValue;
                }

                return value;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    }
}
