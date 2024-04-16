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

		public string Week
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

		public string Monday
		{
			get { return lessons.Monday; }
			set
			{
				if (lessons.Monday != value)
				{
					lessons.Monday = value;
					OnPropertyChanged(nameof(Monday));
				}
			}
		}
		public string Tuesday
		{
			get { return lessons.Tuesday; }
			set
			{
				if (lessons.Tuesday != value)
				{
					lessons.Tuesday = value;
					OnPropertyChanged(nameof(Tuesday));
				}
			}
		}

		public string Wednesday
		{
			get { return lessons.Wednesday; }
			set
			{
				if (lessons.Wednesday != value)
				{
					lessons.Wednesday = value;
					OnPropertyChanged(nameof(Wednesday));
				}
			}
		}

		public string Thursday
		{
			get { return lessons.Thursday; }
			set
			{
				if (lessons.Thursday != value)
				{
					lessons.Thursday = value;
					OnPropertyChanged(nameof(Thursday));
				}
			}
		}

		public string Friday
		{
			get { return lessons.Friday; }
			set
			{
				if (lessons.Friday != value)
				{
					lessons.Friday = value;
					OnPropertyChanged(nameof(Friday));
				}
			}
		}

		public string Saturday
		{
			get { return lessons.Saturday; }
			set
			{
				if (lessons.Saturday != value)
				{
					lessons.Saturday = value;
					OnPropertyChanged(nameof(Saturday));
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
