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
    /// Логика взаимодействия для Page31.xaml
    /// </summary>
    public partial class Page31 : Page
    {
        public Page31()
        {
            InitializeComponent();
            button311.Content = new TextBlock() { Text = "Хорошо. *Артем отправляется в парк откуда все началось , и остается ждать на скамейке.", TextWrapping = TextWrapping.Wrap };
            button31.Content = new TextBlock() { Text = "Нет. *Артем решает выбросить телефон, и забыть о том что произошло.", TextWrapping = TextWrapping.Wrap };
        }

        private void button31_Click(object sender, RoutedEventArgs e)
        {
            frame31.Navigate(new Page32());
        }

        private void button311_Click(object sender, RoutedEventArgs e)
        {
            frame311.Navigate(new Page35());
        }
    }
}
