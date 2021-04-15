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
using NikitaNikitaStory.Pages;

namespace NikitaNikitaStory.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            button4.Content = new TextBlock() { Text = "Подобрать телефон и ответить на звонок", TextWrapping = TextWrapping.Wrap };
            button5.Content = new TextBlock() { Text = "Проигнорировать звонок, и пройти дальше", TextWrapping = TextWrapping.Wrap };

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            frame2.Navigate(new Page3());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            frame55.Navigate(new Page5());
        }
    }
}
