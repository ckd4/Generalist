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
    public partial class Registration : Page
    {
        private Users _currentuser = new Users();
        public Registration()
        {
            InitializeComponent();
        }
        private void PBPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PBPassword1.Password.Length > 0)
                TBPassword1.Visibility = Visibility.Collapsed;
            else
                TBPassword1.Visibility = Visibility.Visible;

            if (PBPassword2.Password.Length > 0)
                TBPassword2.Visibility = Visibility.Collapsed;
            else
                TBPassword2.Visibility = Visibility.Visible;
        }

        private void BTNRegistration_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new GeneralistEntities3();
                var user = db.Users.AsNoTracking().FirstOrDefault(u => u.nickname == TBNicknameReg.Text);

                if (string.IsNullOrEmpty(TBNicknameReg.Text) || string.IsNullOrEmpty(PBPassword1.Password) || string.IsNullOrEmpty(PBPassword1.Password))
                {
                    MessageBox.Show("Введите никнейм и пароль!", "Ошибка Авторизации");
                    return;
                }
                else if (PBPassword1.Password != PBPassword2.Password)
                {
                    MessageBox.Show("Пароли должны совпадать!", "Ошибка Авторизации");
                    return;
                }
                else if (user != null)
                {
                    MessageBox.Show("Такой никнейм уже занят!", "Ошибка Авторизации");
                    return;
                }
                else
                {
                    try
                    {
                        Users u = new Users();
                        u.nickname = TBNicknameReg.Text;
                        u.password = PBPassword1.Password;
                        GeneralistEntities3.GetContext().Users.Add(u);
                        GeneralistEntities3.GetContext().SaveChanges();
                        NavigationService.Navigate(new MainMenu());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Отсутствует подключение к базе данных", "Database Error");
            }
        }

        private void BTNAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorization());
        }
    }
}
