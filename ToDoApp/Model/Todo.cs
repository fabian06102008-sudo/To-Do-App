using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class Todo : INotifyPropertyChanged
    {
		private string? description;

		public string Description
		{
			get { return description; }
			set 
			{ 
				description = value;
				OnPropertyChanged(nameof(Description));
			}
		}

		private bool isDone;

        public bool IsDone
		{
			get { return isDone; }
			set
            {
                isDone = value;
                OnPropertyChanged(nameof(IsDone));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}



    }
}
