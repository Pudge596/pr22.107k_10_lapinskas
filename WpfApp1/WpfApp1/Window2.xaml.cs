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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputText = inputTextBox.Text;

            // Разбиваем строку на слова, используя пробелы в качестве разделителей
            string[] words = inputText.Split(new char[] { ' ', ',','.' }, StringSplitOptions.RemoveEmptyEntries);

            int maxLength = words.Max(word => word.Length);

            resultTextBlock.Text = $"Самое длинное слово имеет длину {maxLength} символов.";
        }
    }
}
   
