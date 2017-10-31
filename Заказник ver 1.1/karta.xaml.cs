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
    /// Логика взаимодействия для karta.xaml
    /// </summary>
    public partial class karta : Window
    {
        public karta()
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

        private void Button_nazad(object sender, RoutedEventArgs e)
        {
            Window1 form2 = new Window1();
            form2.Show();
            this.Hide();
            Close();
        }
    }
}
