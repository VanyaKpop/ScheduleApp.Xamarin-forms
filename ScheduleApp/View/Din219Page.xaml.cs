using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using ScheduleApp.View.WeekPages;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Drawing;
using Xamarin.CommunityToolkit.UI.Views;

namespace ScheduleApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Din219Page : ContentView
	{
		public Din219Page()
		{
			InitializeComponent();

            CurrentWeekDin219 current = new CurrentWeekDin219();


            mytabview.TabItems[0].Content = current;
			mytabview.TabItems[1].Content = new NextWeekDin219();

            Selection();

        }

        void Selection()
		{
			switch (mytabview.TabIndex)
			{
                case 0:
                    NextWeek.BackgroundColor = Xamarin.Forms.Color.White;
                    NextWeekText.TextColor = Xamarin.Forms.Color.Black;
                    CurrentWeek.BackgroundColor = Xamarin.Forms.Color.FromHex("#000000");
                    CurrentWeekText.TextColor = Xamarin.Forms.Color.White;
                    break;
                case 1:
                    CurrentWeek.BackgroundColor = Xamarin.Forms.Color.White;
                    CurrentWeekText.TextColor = Xamarin.Forms.Color.Black;
                    NextWeek.BackgroundColor = Xamarin.Forms.Color.FromHex("#000000");
                    NextWeekText.TextColor = Xamarin.Forms.Color.White;
                    break;
            }
		}

        private void mytabview_SelectionChanged(object sender, TabSelectionChangedEventArgs e)
        {
            switch (e.NewPosition)
            {
                case 0:
                    NextWeek.BackgroundColor = Xamarin.Forms.Color.White;
                    NextWeekText.TextColor = Xamarin.Forms.Color.Black;
                    CurrentWeek.BackgroundColor = Xamarin.Forms.Color.FromHex("#000000");
                    CurrentWeekText.TextColor = Xamarin.Forms.Color.White;
                    break;
                case 1:
                    CurrentWeek.BackgroundColor = Xamarin.Forms.Color.White;
                    CurrentWeekText.TextColor = Xamarin.Forms.Color.Black;
                    NextWeek.BackgroundColor = Xamarin.Forms.Color.FromHex("#000000");
                    NextWeekText.TextColor = Xamarin.Forms.Color.White;
                    break;
            }
        }
    }
}