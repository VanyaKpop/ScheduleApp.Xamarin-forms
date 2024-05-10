using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScheduleApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void SetText()
        {
            int week = (int)ISOWeek.GetWeekOfYear(DateTime.Now) - 1;
            this.BindingContext = new TodayViewModel()
            {

            };
        }
    }
}