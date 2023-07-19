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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window   //window class is the root of a window, provides min, max, close buttons
        //"partial" means it needs to be combined with the xaml file
        //this is done with InitializeComponent() call
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            //accessing resources from the code behind - call to Name.FindResource(resourceName)
            Console.WriteLine(pnlMain.FindResource("strPanel").ToString());
            Console.WriteLine(this.FindResource("strWindow").ToString());
            Console.WriteLine(Application.Current.FindResource("strApp").ToString());
        }
    }
}
