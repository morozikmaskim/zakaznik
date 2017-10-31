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

namespace Заказник_ver_1._1
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
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
            Close();
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Карта_Click(object sender, RoutedEventArgs e)
        {
            karta karta = new karta();
            karta.Show();
            this.Hide();
            Close();
        }
    }
}
