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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Generalist.Pages
{
    public partial class Game : Page
    {
        public Game()
        {
            InitializeComponent();
            var db = new GeneralistEntities3();
            Generalist.Settings.IDArray = GeneralistEntities3.GetContext().Questions.Select(x => x.question_id).ToArray();
        }

        private void GameClose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        int rndid;
        //для подсчета всех вопросов, не забыть про + 1 в рнд

        void GenerateQuestion()
        {
            if (PBTime.Value == 100)
            {
                MessageBox.Show($"Вы набрали {Score.Content} очков", "Поздравляем!");
                NavigationService.Navigate(new MainMenu());
            }
            else
            {
                Random rnd = new Random();

                // заполнение данных
                rndid = Generalist.Settings.IDArray[rnd.Next(0, Generalist.Settings.IDArray.Length)];
                //rndid = rnd.Next(1, GeneralistEntities3.GetContext().Questions.ToList().Count + 1);
                LDiff.Content = GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.Difficulty.description).FirstOrDefault();
                LCateg.Content = GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.Category.description).FirstOrDefault();
                TBQuestion.Text = GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.question).FirstOrDefault();

                // заполнение строк ответами из бд
                string ca = GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.correct_answer).FirstOrDefault();
                string a1 = GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.answer_1).FirstOrDefault();
                string a2 = GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.answer_2).FirstOrDefault();
                string a3 = GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.answer_3).FirstOrDefault();

                // RANDOM GENERATE ANSWERS
                switch (rnd.Next(3))
                {
                    case 0:
                        CA.Content = ca;
                        A1.Content = a1;
                        A2.Content = a2;
                        A3.Content = a3;
                        break;
                    case 1:
                        CA.Content = a2;
                        A1.Content = a3;
                        A2.Content = ca;
                        A3.Content = a1;
                        break;
                    case 2:
                        CA.Content = a3;
                         A1.Content = a2;
                        A2.Content = a1;
                        A3.Content = ca;
                        break;
                    case 3:
                        CA.Content = a1;
                        A1.Content = ca;
                        A2.Content = a3;
                        A3.Content = a2;
                        break;
                }
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateQuestion();
            //ProgressBar pb = new ProgressBar();
            Duration duration = new Duration(TimeSpan.FromSeconds(Generalist.Settings.T4PB));
            DoubleAnimation db = new DoubleAnimation(100, duration);
            PBTime.BeginAnimation(ProgressBar.ValueProperty, db);
            int scr = Convert.ToInt32(Score.Content);
        }

        private string CorrectAnswer()
        {
            return GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.correct_answer).FirstOrDefault();
        }

        //ИВЕНТНЫЙ МЕТОД
        private void ClickAnswer(object sender, RoutedEventArgs e)
        {
            //((Button)sender).Content
            if (((Button)e.Source).Content.ToString() == CorrectAnswer().ToString())
            {
                int scr = Convert.ToInt32(Score.Content);
                switch (LDiff.Content.ToString())
                {
                    case "Лёгкая":
                        scr += 1;
                        break;
                    case "Средняя":
                        scr += 2;
                        break;
                    case "Сложная":
                        scr += 3;
                        break;
                }
                GenerateQuestion();
                Score.Content = scr.ToString();
            }
            else
                GenerateQuestion();
        }

        private void CA_Click(object sender, RoutedEventArgs e)
        {
            if (CA.Content.ToString() == GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.correct_answer).FirstOrDefault())
            {
                int scr = Convert.ToInt32(Score.Content);
                switch (LDiff.Content.ToString())
                {
                    case "Лёгкая":
                        scr += 1;
                        break;
                    case "Средняя":
                        scr += 2;
                        break;
                    case "Сложная":
                        scr += 3;
                        break;
                }
                GenerateQuestion();
                Score.Content = scr.ToString();
            }
            else
                GenerateQuestion();

        }
        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (A1.Content.ToString() == GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.correct_answer).FirstOrDefault())
            {
                int scr = Convert.ToInt32(Score.Content);
                switch (LDiff.Content.ToString())
                {
                    case "Лёгкая":
                        scr += 1;
                        break;
                    case "Средняя":
                        scr += 2;
                        break;
                    case "Сложная":
                        scr += 3;
                        break;
                }
                GenerateQuestion();
                Score.Content = scr.ToString();
            }
            else
                GenerateQuestion();
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (A2.Content.ToString() == GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.correct_answer).FirstOrDefault())
            {
                int scr = Convert.ToInt32(Score.Content);
                switch (LDiff.Content.ToString())
                {
                    case "Лёгкая":
                        scr += 1;
                        break;
                    case "Средняя":
                        scr += 2;
                        break;
                    case "Сложная":
                        scr += 3;
                        break;
                }
                GenerateQuestion();
                Score.Content = scr.ToString();
            }
            else
                GenerateQuestion();
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (A3.Content.ToString() == GeneralistEntities3.GetContext().Questions.ToList().Where(id => id.question_id == rndid).Select(q => q.correct_answer).FirstOrDefault())
            {
                int scr = Convert.ToInt32(Score.Content);
                switch (LDiff.Content.ToString())
                {
                    case "Лёгкая":
                        scr += 1;
                        break;
                    case "Средняя":
                        scr += 2;
                        break;
                    case "Сложная":
                        scr += 3;
                        break;
                }
                GenerateQuestion();
                Score.Content = scr.ToString();
            }
            else
                GenerateQuestion();
        }
    }
}
