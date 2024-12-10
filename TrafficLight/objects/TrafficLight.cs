using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace TrafficLight
{

    public class TrafficLight
    {
        private light _color;

        private Ellipse _GreenLight;
        private Ellipse _YellowLight;
        private Ellipse _RedLight;
        private bool _isAuto = false;
        private DispatcherTimer _autoTimer;

        public TrafficLight(light color, Ellipse GreenLight, Ellipse YellowLight, Ellipse RedLight)
        {

            _color = color;
            _GreenLight = GreenLight;
            _RedLight = RedLight;
            _YellowLight = YellowLight;

            _autoTimer = new DispatcherTimer();
            _autoTimer.Stop();
            _autoTimer.Interval = TimeSpan.FromSeconds(1);
            _autoTimer.Tick += _autoTimer_Tick;
        }
        private void _autoTimer_Tick(object sender, object e)
        {
            NextColor();
        }
        public enum light
        {
            red, green, yellow
        }
        public void SetIsAuto(bool isAuto)
        {
            _isAuto = isAuto;
            if (_isAuto)
            {
                _autoTimer.Start();
            }
            else
                _autoTimer.Stop();
        }
        public bool GetIsAuto()
        {
            return _isAuto;
        }

        public void NextColor()
        {
            Clear();

            switch (_color)
            {
                case (light.red):
                    _color = light.yellow;
                    _YellowLight.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 215, 0));
                    break;
                case (light.yellow):
                    _GreenLight.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 50, 205, 50));
                    _color = light.green;

                    break;
                case (light.green):
                    _color = light.red;
                    _RedLight.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
                    break;
            }
            // הרמזור יוזם אירוע לאחר שהחליף את מצבו
            // בהזדמנות זו הוא מוסר את מצבו המעודכן
            if (Events.OnChange != null) {
                Events.OnChange(_color);
            }
        }

        public void Clear()
        {
            _GreenLight.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(125, 128, 128, 128));
            _YellowLight.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(125, 128, 128, 128));
            _RedLight.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(125, 128, 128, 128));
        }

    }
}
