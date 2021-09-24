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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

    

        private void btnNewSession_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NewSessionPage());
        }


        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HistoryPage());
        }


        private void btnWorkoutLibrary_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WorkoutLibraryPage());
        }






    }
}