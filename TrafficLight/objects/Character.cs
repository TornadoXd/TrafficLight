﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace TrafficLight.objects
{
    public abstract class Character
    {
        public enum StateType
        {
            idle, ready, go
        }
        protected StateType _state;
        protected Image _Image;

        public Character(Image Img)
        {
            _Image = Img;
            _state = StateType.idle;
            MatchGifToState();
            Events.OnChange += ChangeState;
        }

        public void ChangeState(TrafficLight.light state)
        {
            switch (state)
            {
                case TrafficLight.light.red:
                    _state = StateType.idle;
                    break;
                case TrafficLight.light.yellow:
                    _state = StateType.ready;
                    break;
                case TrafficLight.light.green:
                    _state = StateType.go;
                    break;
            }
            MatchGifToState();
        }
        virtual protected void MatchGifToState()
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
