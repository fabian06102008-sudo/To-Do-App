using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using ToDoApp.Model;


namespace ToDoApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Todo> _allTodos;
        public MainViewModel()
        {
            Application.Current.Exit += OnApplicationExit;

            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\JuanR\\Desktop\\C#\\Projects\\ToDoApp\\ToDoApp\\tasksList.json"))
                {
                    string json = sr.ReadToEnd();
                    _allTodos = JsonSerializer.Deserialize<ObservableCollection<Todo>>(json);

                    if (_allTodos == null)
                    {
                        _allTodos = new ObservableCollection<Todo>();
                    }
                }
            }
            catch (JsonException jex)
            {
                _allTodos = new ObservableCollection<Todo>();
            }

            catch (Exception)
            {
                _allTodos = new ObservableCollection<Todo>();
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
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
            SaveTasks();
        }

        private void SaveTasks()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\JuanR\\Desktop\\C#\\Projects\\ToDoApp\\ToDoApp\\tasksList.json"))
            {
                string jsonString = JsonSerializer.Serialize(AllTodos);

                sw.WriteLine(jsonString);
            }
        }

    }
}
