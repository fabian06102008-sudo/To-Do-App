using System.Windows;
using System.Windows.Controls;
using ToDoApp.Model;


namespace ToDoApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for TaskCard.xaml
    /// </summary>
    public partial class TaskCard : UserControl
    {
        public TaskCard()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            if (chk != null)
            {
                var todo = chk.DataContext as Todo;
                
                if (todo != null)
                {
                    todo.IsDone = chk.IsChecked == true;
                }
            }

            if (Checkbox.IsChecked == true)
            {
                Opacity = 0.5;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            if (chk != null)
            {
                var todo = chk.DataContext as Todo;

                if (todo != null)
                {
                    todo.IsDone = chk.IsChecked == true;
                }
            }

            if (chk.IsChecked == false)
            {
                Opacity = 1;
            }
        }
    }
}
