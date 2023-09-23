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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(numberInput.Text);
                string chislo;

                if (number == 0)
                {
                    chislo = "нулевое число";
                }
                else
                {
                    string sign = (number < 0) ? "отрицательное" : "положительное";
                    int absNumber = Math.Abs(number);

                    if (absNumber < 10)
                    {
                        chislo = $"{sign} однозначное число";
                    }
                    else if (absNumber < 100)
                    {
                        chislo = $"{sign} двузначное число";
                    }
                    else
                    {
                        chislo = $"{sign} трехзначное число";
                    }
                }

                descriptionOutput.Text = $"Описание числа: {chislo}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректное целое число.");
            }
        }
    }
}
