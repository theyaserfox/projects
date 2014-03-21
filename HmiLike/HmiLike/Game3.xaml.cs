﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HmiLike
{
    /// <summary>
    /// Interaction logic for Game3.xaml
    /// </summary>
    public partial class Game3 : UserControl
    {
        FormFlashLibrary.FlashAxControl player1 = new FormFlashLibrary.FlashAxControl();
        public Game3()
        {
            InitializeComponent();
            string strFilePath = @"D:\Users\gateway\Desktop\HmiLike\HmiLike\Bunkey.swf";
            SWFFileHeader swfFile = new SWFFileHeader(strFilePath);
            this.Width = swfFile.FrameSize.WidthInPixels;
            this.Height = swfFile.FrameSize.HeightInPixels + 160;
            this.Cursor = Cursors.None;

            WindowsFormsHost host = new WindowsFormsHost();
            //   FormFlashLibrary.FlashAxControl player = new FormFlashLibrary.FlashAxControl();

            //the Windows Forms Host hosts the Flash Player
            host.Child = player1;
            host.Width = (int)this.Width;
            host.Height = (int)this.Height - 160;
            host.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            host.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;

            //the WPF Grid hosts the Windows Forms Host
            Gam3.Children.Add(host);

            //set size
            player1.Width = (int)this.Width;
            player1.Height = (int)this.Height - 160;
            //  image3.Margin = new Thickness(280, player1.Height, 0, 0);

            //image4.Margin = new Thickness(420, player1.Height, 0, 0);
            //load & play the movie
            player1.LoadMovie(strFilePath);
            player1.Play();
            ess.Margin = new Thickness(50, player1.Height, 0, 0);
            ess.Height += 50;
            ess.Width += 50;
            ess.Content = "Games";
            ess.Foreground = Brushes.White;
            ess.FontSize = 48;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Games());
            player1.Dispose();
        }
    }
}
