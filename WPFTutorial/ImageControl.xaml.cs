﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for Imaeg.xaml
    /// </summary>
    public partial class ImageControl : Window
    {
        public ImageControl()
        {
            InitializeComponent();
        }

        //allows the user to load an image from their system
        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgDynamic.Source = new BitmapImage(fileUri);
            }
        }

        private void BtnLoadFromResource_Click(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("/Images/wpf-training.png", UriKind.Relative);
            imgDynamic.Source = new BitmapImage(resourceUri);
        }
    }
}
