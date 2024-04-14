using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Globalization;
using ScheduleApp.ViewModel;

namespace ScheduleApp
{
	public partial class MainPage : ContentPage
	{
        static int week = (int)ISOWeek.GetWeekOfYear(DateTime.Now) - 1;
        public MainPage()
		{
			InitializeComponent();

            SetText();
        }

        void SetText()
		{
            this.BindingContext = new LessonsViewModel
            {
                Week = week
            };
        }

        void OnSwiped(object sender, SwipedEventArgs e)
		{
            switch (e.Direction)
            {
                case SwipeDirection.Right:
                    if (week < 21)
					{
                        week++;
                        SetText();
                    }
                    break;
                case SwipeDirection.Left:
                    if (week > (int)ISOWeek.GetWeekOfYear(DateTime.Now) - 1 | week < (int)ISOWeek.GetWeekOfYear(DateTime.Now) - 1)
					{
                            
                        week = (int)ISOWeek.GetWeekOfYear(DateTime.Now) - 1;
                        SetText();
                    }
                    break;
            }
        }
    }
}
