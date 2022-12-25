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
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            Generalist.Settings.IDArray = GeneralistEntities3.GetContext().Questions.Select(x => x.question_id).ToArray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Settings());
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationService.Navigate(new Game());
            }
            catch
            {
                MessageBox.Show("Не работает((");
            }
            
        }

        private void btnAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddQuestion());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            PageController.MainWindow.Close();
        }
    }
}
