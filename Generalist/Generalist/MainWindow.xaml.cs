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

namespace Generalist
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PageController.MainWindow = this;
            PageController.MainFrame = MainFrame;
            PageController.MainFrame.Navigate(new Pages.Registration());
            Generalist.Settings.T4PB = 60;
        }

        private void MainFrame_Unloaded(object sender, RoutedEventArgs e)
        {
            while(true)
            {
                mediaElement.Play();
            }

        }
    }
}
