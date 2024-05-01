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
	public partial class CurrentWeekDin219 : ContentPage
	{
		public CurrentWeekDin219()
		{
			InitializeComponent();
			SetText();
		}

		void SetText()
		{
			Lessons lessons = new Lessons();

			int week = (int)ISOWeek.GetWeekOfYear(DateTime.Now) - 1;
            this.BindingContext = new LessonsViewModel()
			{
				Week = $"Сейчас {week} неделя",
				Monday = IsEmpty(lessons.JsonLoad("monday", week)),
				Tuesday = IsEmpty(lessons.JsonLoad("tuesday", week)),
				Wednesday = IsEmpty(lessons.JsonLoad("wednesday", week)),
				Thursday = IsEmpty(lessons.JsonLoad("thursday", week)),
				Friday = IsEmpty(lessons.JsonLoad("friday", week)),
				Saturday = IsEmpty(lessons.JsonLoad("saturday", week)),

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