﻿using System;
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
    /// Логика взаимодействия для Page21.xaml
    /// </summary>
    public partial class Page21 : Page
    {
        public Page21()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            frame21.Navigate(new Page22());
        }
    }
}
