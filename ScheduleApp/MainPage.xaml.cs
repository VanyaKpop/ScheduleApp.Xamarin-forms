using ScheduleApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScheduleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Din219Page din219Page = new Din219Page();

            mytabview2.TabItems[0].Content = din219Page;
            mytabview2.TabItems[1].Content = new ProstateExam();
        }
    }
}