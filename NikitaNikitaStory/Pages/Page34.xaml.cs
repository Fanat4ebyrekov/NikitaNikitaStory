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
    /// Логика взаимодействия для Page34.xaml
    /// </summary>
    public partial class Page34 : Page
    {
        public Page34()
        {
            InitializeComponent();
        }

        private void Button34_Click(object sender, RoutedEventArgs e)
        {
            frame34.Navigate(new Page31());
        }
    }
}
