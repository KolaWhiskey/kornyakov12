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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace kornyakov12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Zad1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. Корняков Д.Д. " +
               "Даны катеты прямоугольного треугольника a и b. " +
               "Найти его гипотенузу c и периметр P.",
               "Задание 1",
               MessageBoxButton.OK,
               MessageBoxImage.Asterisk);
        }

        private void Zad2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. Корняков Д.Д. " +
               "Дано целое число, большее 999. Используя одну операцию деления нацело и " +
               "одну операцию взятия остатка от деления, найти цифру, " +
               "соответствующую разряду сотен в записи этого числа.",
               "Задание 2",
               MessageBoxButton.OK,
               MessageBoxImage.Asterisk);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Ochistka_Click(object sender, RoutedEventArgs e)
        {
            Perimert.Clear();
            Gipotinyza.Clear();
            CatetB.Clear();
            CatetA.Clear();
        }

        private void Ochistka2_Click(object sender, RoutedEventArgs e)
        {
            Cislo999.Clear();
            Rezylitat2.Clear();
        }

        private void Razchet1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(CatetA.Text);
                double b = Convert.ToDouble(CatetB.Text);
                if (a > 0 && b > 0)
                {
                    Class.Reshenie(a, b, out double pr, out double gip);
                    Perimert.Text = pr.ToString();
                    Gipotinyza.Text = gip.ToString();

                }
                else
                {
                    MessageBox.Show("Я работаю только с цифрами > 0");
                }

            }
            catch
            {
                MessageBox.Show("Долой буквы");
            }
        }

        private void Razchet2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(Cislo999.Text);

                int b = Class.Reshenie1(a);
                Rezylitat2.Text = b.ToString();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Долой буквы");
            }
        }

        DispatcherTimer timer;
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Time.Text = dateTime.ToString("hh:mm:ss");
            Data.Text = dateTime.ToString("dd.MM.yyyy");
        }


    }
}
