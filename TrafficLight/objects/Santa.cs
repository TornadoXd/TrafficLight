using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace TrafficLight.objects 
{
    public class Santa : Character
    {

        public Santa(Image Img) : base(Img)
        {
        }
        protected override void MatchGifToState()
        {
            switch (_state)
            {
                case StateType.idle:
                    _Image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Gifs/santa_idle.gif"));
                    break;
                case StateType.ready:
                    _Image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Gifs/santa_jump.gif"));
                    break;
                case StateType.go:
                    _Image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Gifs/santa_run.gif"));
                    break;
            }

        }

    }
}
