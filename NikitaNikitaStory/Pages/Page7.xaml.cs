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

namespace NikitaNikitaStory.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
            button77.Content = new TextBlock() { Text = "Прислушаться и вернуться домой.", TextWrapping = TextWrapping.Wrap };
            button88.Content = new TextBlock() { Text = "Не слушать незнакомца, и отправится в ТЦ.", TextWrapping = TextWrapping.Wrap };
        }

        private void button88_Click(object sender, RoutedEventArgs e)
        {
            frame88.Navigate(new Page8());
        }

        private void button77_Click(object sender, RoutedEventArgs e)
        {
            frame77.Navigate(new Page10());
        }
    }
}
