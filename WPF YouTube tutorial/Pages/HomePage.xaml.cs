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


        // Event handler for button click. Sends the user to page which enables him to make a new session of a workout.

        private void btnNewSession_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NewSessionPage());
        }

        // Event handler for button click. Sends the user to the page which shows previously entered workout sessions. (Workout history)

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HistoryPage());
        }

        // Event handler for button click. Sends the user to the library page (Type of a workout wikipedia with described workouts)

        private void btnWorkoutLibrary_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WorkoutLibraryPage());
        }






    }
}
