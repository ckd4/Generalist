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

namespace Generalist.Pages
{
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Savee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Generalist.Settings.T4PB = Convert.ToInt32(TBTime.Text);
                NavigationService.Navigate(new MainMenu());
            }
            catch
            {   MessageBox.Show("Error"); }
        }

        private void GameClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }
    }
}
