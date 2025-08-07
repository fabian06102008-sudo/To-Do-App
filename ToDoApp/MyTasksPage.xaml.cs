using System.Windows;
using System.Windows.Controls;
using ToDoApp.Model;
using ToDoApp.ViewModel;

namespace ToDoApp
{
    public partial class MyTasksPage : Page
    {
        public MainViewModel ViewModel { get; }
        public MyTasksPage(MainViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            DataContext = vm;
        }

        private void OnClearFinishedTaskBtn(object sender, RoutedEventArgs e)
        {
            List<Todo> tempListToDelete = new List<Todo>();
            
            foreach (Todo todo in ViewModel.AllTodos)
            {
                if (todo.IsDone == true)
                {
                    tempListToDelete.Add(todo);
                }
            }

            foreach (Todo todo in tempListToDelete)
            {
                ViewModel.AllTodos.Remove(todo);
            }
        }
    }
}
