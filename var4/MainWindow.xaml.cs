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

namespace var4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void textBoxEmpty()
        {
            if(textBox1.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Заполните поле 1", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (textBox2.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Заполните поле 2", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (textBox3.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Заполните поле 3", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBoxEmpty();
                double a, b, c;
                int k;
                string d;
                Random r = new Random();
                label2.Content = "";
                d = Convert.ToString(textBox3.Text);
                for (int i = 0; i < d.Length; i++)
                {
                    if (!char.IsDigit(d[i]))
                    {
                        k = r.Next(0,10);
                        textBox3.Text = Convert.ToString(k);
                    }
                }

                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                if (c < 0 || a < 0 || b < 0)
                {
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                    c = Math.Abs(c);
                }

                if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
                {
                    if (a == b && b == c)
                    {
                        label2.Content = "Равносторонний";
                    }
                    else if ((a == b || b == c || a == c) && ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)))
                    {
                        label2.Content = "Прямоугольный и равнобедренный";
                    }
                    else if (a == b || b == c || a == c)
                    {
                        label2.Content = "Равнобедренный";
                    }
                    else if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                    {
                        label2.Content = "Прямоугольный";
                    }
                    else
                    {
                        label2.Content = "Разносторонний";
                    }
                }
                else
                {
                    MessageBox.Show("Такого треугольника не существует");
                }
            }

            catch
            {
               
            }
        }
            
        private void textBox3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.Text, 0));
        }

        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.Text, 0));
        }

        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.Text, 0));
            
        }

        
    }
}
