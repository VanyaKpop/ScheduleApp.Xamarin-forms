using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ScheduleApp.View;
using ScheduleApp.View.WeekPages;
using Xamarin.CommunityToolkit.UI.Views;

namespace ScheduleApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

            Din219Page current = new Din219Page();

			

            Shell.SetNavBarHasShadow(this, false);
			Shell.SetNavBarIsVisible(this, false);
        }
    }
}