﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace WpfControls.Pages
{
  /// <summary>
  /// Interaction logic for FadeElementPage.xaml
  /// </summary>
  public partial class FadeElementPage : Page
  {
    public FadeElementPage()
    {
      InitializeComponent();
    }

    private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
      if (Image1.Opacity > 0)
      {
        FadeOutImage();
      }
      else
      {
        FadeInImage();
      }

    }

    private void FadeOutImage()
    {
      var animation = new DoubleAnimation
      {
        To = 0,
        Duration = TimeSpan.FromSeconds(2),
        FillBehavior = FillBehavior.Stop
      };

      animation.Completed += (s, a) => Image1.Opacity = 0;

      Image1.BeginAnimation(UIElement.OpacityProperty, animation);
    }

    private void FadeInImage()
    {
      var animation = new DoubleAnimation
      {
        To = 1,
        Duration = TimeSpan.FromSeconds(2),
        FillBehavior = FillBehavior.Stop
      };

      animation.Completed += (s, a) => Image1.Opacity = 1;

      Image1.BeginAnimation(UIElement.OpacityProperty, animation);
    }
  }
}