﻿using System;
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
    /// Interaction logic for UsingCustomDialog.xaml
    /// </summary>
    public partial class UsingCustomDialog : Window
    {
        public UsingCustomDialog()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            CustomDialogs inputDialog = new CustomDialogs("Please enter your name:", "Cris!");
            if (inputDialog.ShowDialog() == true)
                lblName.Text = inputDialog.Answer;
        }
    }
}
