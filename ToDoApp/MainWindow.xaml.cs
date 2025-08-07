using System.IO;
using System.Windows;
using ToDoApp.ViewModel;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; }
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            DataContext = ViewModel;

            MainWindowsFrame.Navigate(new MyTasksPage(ViewModel));
        }


    }
}