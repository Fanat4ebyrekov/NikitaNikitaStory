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
    /// Логика взаимодействия для Page32.xaml
    /// </summary>
    public partial class Page32 : Page
    {
        public Page32()
        {
            InitializeComponent();
        }

        private void button32_Click(object sender, RoutedEventArgs e)
        {
            frame32.Navigate(new Page33());
        }
    }
}
