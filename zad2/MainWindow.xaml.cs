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

namespace zad2
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                int x11, x12, y11, y12, z11, z12, x21, x22, y21, y22, z21, z22, l1, l2, m1, m2, n1, n2, k1, k2, k3;
                x11 = Convert.ToInt32(textBox1.Text);
                y11 = Convert.ToInt32(textBox2.Text);
                z11 = Convert.ToInt32(textBox3.Text);
                y12 = Convert.ToInt32(textBox4.Text);
                x12 = Convert.ToInt32(textBox5.Text);
                z12 = Convert.ToInt32(textBox6.Text);

                x21 = Convert.ToInt32(textBox7.Text);
                y21 = Convert.ToInt32(textBox8.Text);
                z21 = Convert.ToInt32(textBox9.Text);
                y22 = Convert.ToInt32(textBox10.Text);
                x22 = Convert.ToInt32(textBox11.Text);
                z22 = Convert.ToInt32(textBox12.Text);

                l1 = x12 - x11;
                l2 = x22 - x21;
                m1 = y12 - y11;
                m2 = y22 - y21;
                n1 = z12 - z11;
                n2 = z22 - z21;

                k1 = x21 - x11;
                k2 = y21 - y11;
                k3 = z21 - z11;

                
                if ((k1 * m1 * n2) + (k2 * n1 * l2) + (k3 * l1 * m2) - (k3* m1 * l2) + (k2 * l1 * n2) + (k1 * n1 * m2) == 0)
                {                 
                    label1.Content = "Прямые лежат в одной плоскости";
                    label3.Content = "Нет";
                }
                else
                {
                    label3.Content = "Да";
                    label1.Content = "Прямые лежат в разных плоскостях";
                };

                if ( l1 != 0 && l2 != 0 && m1 != 0 && m2 != 0 && n1 !=0 && n2 != 0)
                {
                    if ((l1 / l2 == m1 / m2) && (m1 / m2 == n1 / n2))
                    {
                        label2.Content = "Прямые параллельны";
                    }
                    else
                    {
                        label2.Content = "Прямые не параллельны";
                    }
                }
                else
                {
                    label2.Content = "У вас тут нолики сука";
                };
            }
            catch
            {
                textBox1.Text = "КЕТЧБРАТ";
                btn1.IsEnabled = false;
            }

        }
    }
}
