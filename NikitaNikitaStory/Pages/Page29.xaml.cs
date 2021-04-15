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
    /// Логика взаимодействия для Page29.xaml
    /// </summary>
    public partial class Page29 : Page
    {
        public Page29()
        {
            InitializeComponent();
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            frame29.Navigate(new Page30());
        }
    }
}
