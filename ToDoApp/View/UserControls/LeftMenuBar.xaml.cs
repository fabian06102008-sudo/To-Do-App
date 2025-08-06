using System.Windows;
using System.Windows.Controls;
using ToDoApp.ViewModel;
using ToDoApp.View;


namespace ToDoApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for LeftMenuBar.xaml
    /// </summary>
    public partial class LeftMenuBar : UserControl
    {
        public LeftMenuBar()
        {
            
            InitializeComponent();
        }

        private void OnMyTasksBtn(object sender, RoutedEventArgs e)
        {
            var mainWin = Application.Current.MainWindow as MainWindow;
            if (mainWin != null)
            {
                mainWin.MainWindowsFrame.Navigate(new MyTasksPage(mainWin.ViewModel));
            }
        }

        private void OnAddTaskBtn(object sender, RoutedEventArgs e)
        {
            var mainWin = Application.Current.MainWindow as MainWindow;
            if (mainWin != null)
            {
                mainWin.MainWindowsFrame.Navigate(new AddTaskPage(mainWin.ViewModel));
            }
        }
    }
}
