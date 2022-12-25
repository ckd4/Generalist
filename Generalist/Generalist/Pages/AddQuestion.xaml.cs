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
    public partial class AddQuestion : Page
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new GeneralistEntities3();
                Questions q = new Questions();
                q.difficulty_id = AddDiff.SelectedIndex + 1;
                q.category_id = AddCat.SelectedIndex + 1;
                q.question = AddQ.Text;
                q.correct_answer = AddCA.Text;
                q.answer_1 = AddA1.Text;
                q.answer_2 = AddA2.Text;
                q.answer_3 = AddA3.Text;
                GeneralistEntities3.GetContext().Questions.Add(q);
                GeneralistEntities3.GetContext().SaveChanges();
                MessageBox.Show("Ваш вопрос был успешно добавлен!","Успешное добавление в БД");
            }
            catch
            {
                MessageBox.Show("Внесите все данные корректно и попробуйте ещё раз", "Ошибка добавления в БД");
            }
        }

        private void GameClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }
    }
}
