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
    /// Interaction logic for MessageBoxes.xaml
    /// </summary>
    public partial class MessageBoxes : Window
    {
        public MessageBoxes()
        {
            InitializeComponent();
        }

        private void btnSimpleMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }

        private void btnMessageBoxWithTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!", "My App");
        }

        private void btnMessageBoxWithButtons_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This MessageBox has extra options.\n\nHello, world?", "My App", MessageBoxButton.YesNoCancel);
        }

        private void btnMessageBoxWithResponse_Click(object sender, RoutedEventArgs e)
        {
            //the response is on MessageBoxResult object
            MessageBoxResult result = MessageBox.Show("Would you like to greet the world with a \"Hello, world\"?", "My App", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Hello to you too!", "My App");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Oh well, too bad!", "My App");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Nevermind then...", "My App");
                    break;
            }
        }

        private void btnMessageBoxWithIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!", "My App", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnMessageBoxWithDefaultChoice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world?", "My App", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
        }

        private void btnMessageBoxAnnoying_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Why did you call me...", "Annoying Box", MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK:
                    MessageBoxResult result1 = MessageBox.Show("Ok what...?", "Annoying Box", MessageBoxButton.OKCancel);
                    switch (result1)
                    {
                        case MessageBoxResult.OK:
                            MessageBox.Show("Yeah, fine, go...", "My App" , MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            break;
                   
                        case MessageBoxResult.Cancel:
                            MessageBox.Show("Nevermind...", "My App", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                            break;
                    }
                    break;
                case MessageBoxResult.Cancel:
                    MessageBoxResult result2 = MessageBox.Show("Canceling on me...?", "Annoying Box", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                    switch (result2)
                    {
                        case MessageBoxResult.OK:
                            MessageBox.Show("Now ok?? sure bud...", "My App", MessageBoxButton.OK, MessageBoxImage.Question);
                            break;

                        case MessageBoxResult.Cancel:
                            MessageBox.Show("Cancel me again, I dare you...", "My App", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                    }
                    break;
                   
            }
        }

    }
}
