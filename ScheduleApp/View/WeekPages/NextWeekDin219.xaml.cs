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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NextWeekDin219 : ContentPage
	{
		public NextWeekDin219 ()
		{
			InitializeComponent ();
			SetText();
		}
		void SetText()
		{
			Lessons lessons = new Lessons();

			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(CurrentWeekDin219)).Assembly;
			this.BindingContext = new LessonsViewModel()
			{
				Week = $"Следующая неделя: {(int)ISOWeek.GetWeekOfYear(DateTime.Now)}",
				Monday = lessons.JsonLoad("monday", (int)ISOWeek.GetWeekOfYear(DateTime.Now), assembly.GetManifestResourceStream("ScheduleApp.Data.Lesson.json")),
				Tuesday = lessons.JsonLoad("tuesday", (int)ISOWeek.GetWeekOfYear(DateTime.Now), assembly.GetManifestResourceStream("ScheduleApp.Data.Lesson.json")),
				Wednesday = lessons.JsonLoad("wednesday", (int)ISOWeek.GetWeekOfYear(DateTime.Now), assembly.GetManifestResourceStream("ScheduleApp.Data.Lesson.json")),
				Thursday = lessons.JsonLoad("thursday", (int)ISOWeek.GetWeekOfYear(DateTime.Now), assembly.GetManifestResourceStream("ScheduleApp.Data.Lesson.json")),
				Friday = lessons.JsonLoad("friday", (int)ISOWeek.GetWeekOfYear(DateTime.Now), assembly.GetManifestResourceStream("ScheduleApp.Data.Lesson.json")),
				Saturday = lessons.JsonLoad("saturday", (int)ISOWeek.GetWeekOfYear(DateTime.Now), assembly.GetManifestResourceStream("ScheduleApp.Data.Lesson.json")),

			};
		}
	}
}