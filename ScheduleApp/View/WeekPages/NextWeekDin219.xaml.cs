using System;
using System.Reflection;
using System.IO;
using System.Globalization;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ScheduleApp.ViewModel;
using lessons;

namespace ScheduleApp.View.WeekPages
{
	public partial class NextWeekDin219 : ContentView
	{
		public NextWeekDin219 ()
		{
			InitializeComponent ();
			SetText();
		}
		async void SetText()
		{
			Lessons lessons = new Lessons();
			DateTime Date = new DateTime(2024, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
			int week = (int)ISOWeek.GetWeekOfYear(Date) + 1;
			this.BindingContext = new LessonsViewModel()
			{
				Week = $"{week} неделя",
				Monday = IsEmpty(await lessons.JsonLoad("monday", week)),
				Tuesday = IsEmpty(await lessons.JsonLoad("tuesday", week)),
				Wednesday = IsEmpty(await lessons.JsonLoad("wednesday", week)),
				Thursday = IsEmpty(await lessons.JsonLoad("thursday", week)),
				Friday = IsEmpty(await lessons.JsonLoad("friday", week)),
				Saturday = IsEmpty(await lessons.JsonLoad("saturday", week)),
			};
		}
		string IsEmpty(string str)
        {
            if (str == null | str == "")
                return "Пусто";
            return str;
        }
    }
}