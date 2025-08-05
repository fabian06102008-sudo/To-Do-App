using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string? addTaskBound;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string AddTaskBound
        {
            get
            {
                return addTaskBound;
            }
            set
            {
                addTaskBound = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AddTaskBound"));
            }
        }
    }
}
