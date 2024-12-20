using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace TrafficLight.objects
{
    class Dog : Character
    {
        public Dog(Image Img) : base(Img)
        {
        }
        protected override void MatchGifToState()
        {
            switch (_state)
            {
                case StateType.idle:
                    _Image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Gifs/dog_Idle.gif"));
                    break;
                case StateType.ready:
                    _Image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Gifs/dog_jump.gif"));
                    break;
                case StateType.go:
                    _Image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Gifs/dog_run.gif"));
                    break;
            }
        }

    }
}
