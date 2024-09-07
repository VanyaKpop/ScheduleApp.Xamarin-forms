using lessons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScheduleApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exam : ContentPage
	{
		public Exam()
		{
			InitializeComponent();
		}
		private async void OnButtonClicked(object sender, System.EventArgs e)
		{
			try
			{
				HttpClient httpClient = new HttpClient();
				string resulteParse = await httpClient.GetStringAsync("https://raw.githubusercontent.com/VanyaKpop/JsonFiles/main/Lessons_Din_219.json");

				var assembly = IntrospectionExtensions.GetTypeInfo(typeof(Lessons)).Assembly;

				

				using (StreamWriter writer = new StreamWriter(assembly.GetFile("ScheduleApp.Data.Lesson.json")))
				{
					await writer.WriteAsync(resulteParse);
				}

				DisplayAlert("Обновилось!", "", "Ладно");
			}
			catch (Exception ex)
			{
				DisplayAlert("Ой. Ошибка какая-то", ex.Message, "Ладно");
			}
		}
	}
}