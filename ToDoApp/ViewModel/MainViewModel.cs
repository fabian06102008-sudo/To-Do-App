using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Model;
using System.Text.Json;
using System.Windows;


namespace ToDoApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        public MainViewModel()
        {
            _allTodos = new ObservableCollection<Todo>();
            Application.Current.Exit += OnApplicationExit;

            using (StreamReader sr = new StreamReader("C:\\Users\\JuanR\\Desktop\\C#\\Projects\\ToDoApp\\ToDoApp\\tasksList.json"))
            {
                string json = sr.ReadToEnd();
                _allTodos = JsonSerializer.Deserialize<ObservableCollection<Todo>>(json);
            }
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

        private void OnApplicationExit(object sender, ExitEventArgs e)
        {

        }

    }
}
