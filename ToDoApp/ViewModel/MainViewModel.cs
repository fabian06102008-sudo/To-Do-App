using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Model;

namespace ToDoApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public MainViewModel()
        {
            _allTodos = new ObservableCollection<Todo>()
            {
                new Todo() {Description = "Get out with friends", IsDone = false}
            };

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<Todo> _allTodos;
        public ObservableCollection<Todo> AllTodos
        {
            get { return _allTodos; }
            set
            {
                _allTodos = value;
                OnPropertyChanged(nameof(AllTodos));
            }


        }
    }
}
