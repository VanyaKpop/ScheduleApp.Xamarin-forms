using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScheduleApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllWeeksPage : TabbedPage
	{
		public AllWeeksPage()
		{
			InitializeComponent();
		}
	}
}