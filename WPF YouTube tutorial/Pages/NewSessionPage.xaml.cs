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
    /// Interaction logic for NewSessionPage.xaml
    /// </summary>
    public partial class NewSessionPage : Page
    {
        public NewSessionPage()
        {
            InitializeComponent();
        }

        int setCounter = 1;



        // Event handler for button click. Sends the user to the Home Page (Home Button)
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new HomePage());
        }


        private void generateNewSet()
        {
            setCounter++;

            Grid workoutNewSet_grid = new Grid();
            workoutNewSet_grid.Margin = new Thickness(0, 0, 0, 50);
            workoutNewSet_grid.Name = "Zdenko";



            ColumnDefinition column1 = new ColumnDefinition();
            column1.Width = new GridLength(2, GridUnitType.Star);
            workoutNewSet_grid.ColumnDefinitions.Add(column1);



            //Column which contains set label

            ColumnDefinition column2 = new ColumnDefinition();
            column2.Width = new GridLength(1, GridUnitType.Star);
            workoutNewSet_grid.ColumnDefinitions.Add(column2);

            Label setLabel = new Label();
            setLabel.Content = setCounter + ".";

            Style labelStyle = this.FindResource("defaultLabel") as Style;
            setLabel.Style = labelStyle;

            workoutNewSet_grid.Children.Add(setLabel);
            Grid.SetColumn(setLabel, 1);



            //Column which contains repetitions input field

            ColumnDefinition column3 = new ColumnDefinition();
            column3.Width = new GridLength(1, GridUnitType.Star);
            workoutNewSet_grid.ColumnDefinitions.Add(column3);

            TextBox repsTextBox = new TextBox();

            Style textboxStyle = this.FindResource("defaultTextBox") as Style;
            repsTextBox.Style = textboxStyle;

            workoutNewSet_grid.Children.Add(repsTextBox);
            Grid.SetColumn(repsTextBox, 2);



            //Column which contains weight input field


            ColumnDefinition column4 = new ColumnDefinition();
            column4.Width = new GridLength(1, GridUnitType.Star);
            workoutNewSet_grid.ColumnDefinitions.Add(column4);


            TextBox weightTextBox = new TextBox();

            weightTextBox.Style = textboxStyle;

            workoutNewSet_grid.Children.Add(weightTextBox);
            Grid.SetColumn(weightTextBox, 3);


            workoutSetsStackPanel.Children.Add(workoutNewSet_grid);


            //loop which gets child elements of workoutSetsStackPanel - to get grid children need to repeat the loop withing the child itself


            /*
            int count = workoutSetsStackPanel.Children.Count;
            for (int itr = 0; itr < count; itr++)
            {
                if (workoutSetsStackPanel.Children[itr] is Grid 
                    && ((Grid)workoutSetsStackPanel.Children[itr]).Name.Equals(workoutNewSet_grid.Name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("YEEEET");
                }
            }

            */
        }


        private void btnAddNewSet(object sender, RoutedEventArgs e)
        {

            generateNewSet();

        }

        private void btnRemoveSet(object sender, RoutedEventArgs e)
        {
            workoutSetsStackPanel.Children.RemoveAt(workoutSetsStackPanel.Children.Count - 1);
            setCounter--;


        }


        private void btnAddNewWorkout(object sender, RoutedEventArgs e)
        {




        }


    }
}
