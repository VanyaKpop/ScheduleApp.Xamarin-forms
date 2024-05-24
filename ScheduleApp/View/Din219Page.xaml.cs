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
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;

namespace ScheduleApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Din219Page : ContentPage
	{
        
		public Din219Page()
		{
			InitializeComponent();
            
            CurrentWeekDin219 current = new CurrentWeekDin219();


            mytabview.TabItems[0].Content = current;
			mytabview.TabItems[1].Content = new NextWeekDin219();

        }

        private void mytabview_SelectionChanged(object sender, TabSelectionChangedEventArgs e)
        {
            switch (e.NewPosition)
            {
                case 0:
                    _BoxView.TranslateTo(CurrentWeekText.X, CurrentWeekText.Y, 150, Easing.Linear);
                    break;
                case 1:
                    _BoxView.TranslateTo(NextWeekText.X, NextWeekText.Y, 150, Easing.Linear);
                    break;
            }
        }
    }
}