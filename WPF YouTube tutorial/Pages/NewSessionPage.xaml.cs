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

namespace WPF_YouTube_tutorial.Pages
{
    /// <summary>
    /// Interaction logic for NewSessionPage.xaml
    /// </summary>
    public partial class NewSessionPage : Page
    {
        public NewSessionPage()
        {
            InitializeComponent();
        }



        // Event handler for button click. Sends the user to the Home Page (Home Button)
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new HomePage());
        }





    }
}
