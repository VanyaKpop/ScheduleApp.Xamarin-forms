using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using ScheduleApp.Model;

namespace ScheduleApp.ViewModel
{
	class LessonsViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private LessonsModel lessons;

		public LessonsViewModel()
		{
			lessons = new LessonsModel();
		}

		public int Week
		{
			get { return lessons.Week; }

			set
			{
				if (lessons.Week != value)
				{
					lessons.Week = value;
					OnPropertyChanged(nameof(Week));
				}
			}

		}

		protected void OnPropertyChanged(string propName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}
}
