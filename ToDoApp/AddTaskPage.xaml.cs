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
using ToDoApp.ViewModel;
using ToDoApp.Model;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for AddTaskPage.xaml
    /// </summary>
    public partial class AddTaskPage : Page
    {
        public MainViewModel ViewModel { get; }
        public AddTaskPage(MainViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            DataContext = vm;
        }

        private void OnAddBtn_Click(object sender, RoutedEventArgs e)
        {
            Todo todo = new Todo()
            {
                Description = TaskNameAdd.Text,
                IsDone = false
            };

            ViewModel.AllTodos.Add(todo);

            TaskNameAdd.Text = "";
        }
    }
}
