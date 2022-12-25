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
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            DGQ.ItemsSource = GeneralistEntities3.GetContext().Questions.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Generalist.Settings.IDArray.RemoveAt(Convert.ToInt32(QuestionNumber.Text.ToString()) + 1);
                MessageBox.Show("Успешно удалено!");
            }
            catch
            {
                MessageBox.Show("Неправильный формат");
            }
        }

        private void AddQ_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Generalist.Settings.IDArray.Append(Convert.ToInt32(QuestionNumber.Text.ToString()));
                MessageBox.Show("Успешно добавлено!");
            }
            catch
            {
                MessageBox.Show("Неправильный формат");
            }
        }
    }
}
