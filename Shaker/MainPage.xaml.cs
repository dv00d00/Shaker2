using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Shaker
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int RandomSignum()
        {
            var random = new Random();
            return random.Next(-1, 0) != 0 ? 1 : -1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var duration = new Duration(TimeSpan.FromSeconds(0.5));

            var doubleAnimationScaleX = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 1,
                To = 0.7
            };
            
            var doubleAnimationScaleY = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 1,
                To = 0.7
            };

            var random = new Random();

            var doubleAnimationRotate = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 0,
                To = RandomSignum() * random.Next(45, 90)
            };

            var opacityAnimation = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 0,
                To = 0.5,
                
            };

            var translateX = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 0,
                To = RandomSignum() * random.Next(75, 125),
                
            };
            
            var translateY = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 0,
                To = RandomSignum() * random.Next(75, 125),
            };

            var sb = new Storyboard();
            sb.Children.Add(doubleAnimationScaleX);
            sb.Children.Add(doubleAnimationScaleY);
            sb.Children.Add(doubleAnimationRotate);
            sb.Children.Add(opacityAnimation);
            sb.Children.Add(translateX);
            sb.Children.Add(translateY);
            sb.Duration = duration;

            Storyboard.SetTarget(doubleAnimationScaleX, transform);
            Storyboard.SetTarget(doubleAnimationScaleY, transform);
            Storyboard.SetTarget(doubleAnimationRotate, transform);
            Storyboard.SetTarget(opacityAnimation, opacityMask);
            Storyboard.SetTarget(translateX, transform);
            Storyboard.SetTarget(translateY, transform);

            Storyboard.SetTargetProperty(doubleAnimationScaleX, new PropertyPath("ScaleX"));
            Storyboard.SetTargetProperty(doubleAnimationScaleY, new PropertyPath("ScaleY"));
            Storyboard.SetTargetProperty(doubleAnimationRotate, new PropertyPath("Rotation"));
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath("Opacity"));

            Storyboard.SetTargetProperty(translateX, new PropertyPath("TranslateX"));
            Storyboard.SetTargetProperty(translateY, new PropertyPath("TranslateY"));

            sb.Begin();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var duration = new Duration(TimeSpan.FromSeconds(0.5));

            var doubleAnimationScaleX = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 0.7,
                To = 1
            };

            var doubleAnimationScaleY = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 0.7,
                To = 1
            };

            var random = new Random();

            var doubleAnimationRotate = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From =  RandomSignum() * random.Next(45, 90),
                To = 0
            };

            var opacityAnimation = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = 0.5,
                To = 0,
            };

            var translateX = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = RandomSignum() * random.Next(75, 125),
                To = 0

            };

            var translateY = new DoubleAnimation
            {
                AutoReverse = false,
                Duration = duration,
                From = RandomSignum() * random.Next(75, 125),
                To = 0
            };

            var sb = new Storyboard();
            sb.Children.Add(doubleAnimationScaleX);
            sb.Children.Add(doubleAnimationScaleY);
            sb.Children.Add(doubleAnimationRotate);
            sb.Children.Add(opacityAnimation);
            sb.Children.Add(translateX);
            sb.Children.Add(translateY);
            sb.Duration = duration;

            Storyboard.SetTarget(doubleAnimationScaleX, transform);
            Storyboard.SetTarget(doubleAnimationScaleY, transform);
            Storyboard.SetTarget(doubleAnimationRotate, transform);
            Storyboard.SetTarget(opacityAnimation, opacityMask);
            Storyboard.SetTarget(translateX, transform);
            Storyboard.SetTarget(translateY, transform);

            Storyboard.SetTargetProperty(doubleAnimationScaleX, new PropertyPath("ScaleX"));
            Storyboard.SetTargetProperty(doubleAnimationScaleY, new PropertyPath("ScaleY"));
            Storyboard.SetTargetProperty(doubleAnimationRotate, new PropertyPath("Rotation"));
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath("Opacity"));

            Storyboard.SetTargetProperty(translateX, new PropertyPath("TranslateX"));
            Storyboard.SetTargetProperty(translateY, new PropertyPath("TranslateY"));

            result.Text = new[] {"Да", "Нет", "Возможно", "Не знаю"}[random.Next(0,3)];

            sb.Begin();
        }
    }
}
