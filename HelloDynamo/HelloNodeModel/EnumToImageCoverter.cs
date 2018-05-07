using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace HelloDynamo.HelloNodeModel
{


    public class EnumToImageCoverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                switch (value.ToString())
                {
                    case "Pocket Space":
                        return new BitmapImage(new Uri(@"Images\ref1.png", UriKind.Relative));
                    case "Small Plaza":
                        return new BitmapImage(new Uri(@"Images\ref2.png", UriKind.Relative));
                    case "Medium Plaza":
                        return new BitmapImage(new Uri(@"Images\ref3.png", UriKind.Relative));
                    case "Large Plaza":
                        return new BitmapImage(new Uri(@"Images\ref4.png", UriKind.Relative));
                }
                
            }

            return new BitmapImage(new Uri(@"Images\1.png", UriKind.Relative));

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
