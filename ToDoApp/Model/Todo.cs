using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class Todo
    {
		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private bool isDone;

		public bool IsDone
		{
			get { return isDone; }
			set { isDone = value; }
		}


	}
}
