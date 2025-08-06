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
using System.ComponentModel;

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
