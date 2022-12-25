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
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            PageController.MainFrame.Navigate(new Pages.Registration());
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (TBNickname.Text.ToString() == "admin" && PBPassword.Password.ToString() == "admin")
            {
                PageController.MainFrame.Navigate(new Pages.AdminPage());
            }
            else
            {
                try
                {
                    var db = new GeneralistEntities3();
                    var user = db.Users.AsNoTracking().FirstOrDefault(u => u.nickname == TBNickname.Text.ToString());
                    var pass = db.Users.AsNoTracking().FirstOrDefault(u => u.nickname == TBNickname.Text.ToString() && u.password != PBPassword.Password.ToString());

                    if (string.IsNullOrEmpty(TBNickname.Text) || string.IsNullOrEmpty(PBPassword.Password))
                    {
                        MessageBox.Show("Введите никнейм и пароль!", "Ошибка Авторизации");
                        return;
                    }
                    else if (user == null)
                    {
                        MessageBox.Show("Пользователь не найден!", "Ошибка Авторизации");
                        return;
                    }
                    else if (pass != null)
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка Авторизации");
                        return;
                    }
                    else
                        PageController.MainFrame.Navigate(new Pages.MainMenu());
                }
                catch
                {
                    MessageBox.Show("Отсутствует подключение к базе данных", "Database Error");
                }
            }
        }
        private void PBPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBPassword.Password.Length > 0)
                TBPassword.Visibility = Visibility.Collapsed;
            else
                TBPassword.Visibility = Visibility.Visible;
        }
    }
}
