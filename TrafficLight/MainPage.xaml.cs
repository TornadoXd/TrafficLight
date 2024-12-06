using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TrafficLight
{

    public sealed partial class MainPage : Page
    {
        TrafficLight TrafficLight;
        private objects.Santa ziv;
        private objects.Dog Dog;
        private bool _isAuto;
        public MainPage()
        {


            this.InitializeComponent();
            TrafficLight = new TrafficLight(TrafficLight.light.red, greenLight, yellowLight, redLight);
            TrafficLight.Clear();
            ziv = new objects.Santa(santaImg);
            Dog = new objects.Dog(DogImg);

        }

        private void ManualBtn_Click(object sender, RoutedEventArgs e)
        {
            TrafficLight.NextColor();
        }

        private void AutoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_isAuto)
                _isAuto = false;
            else
                _isAuto = true;
            TrafficLight.SetIsAuto(_isAuto);
            if (TrafficLight.GetIsAuto())
            {
                AutoBtn.Content = "Stop";
                ManualBtn.IsEnabled = false;
            }
            else
            {
                AutoBtn.Content = "Start";
                ManualBtn.IsEnabled = true;
            }
        }
    }
}
