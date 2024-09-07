using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Android.Content.Res;
using Newtonsoft.Json;
using System.Linq;

using System.Net.Http;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace lesson
{
    class Lessons
    {
        string dayOfWeek = DateTime.Now.DayOfWeek.ToString().ToLower();
	    static DateTime Date = new DateTime(2024, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
		int week = (int)ISOWeek.GetWeekOfYear(Date);
		private HttpClient httpClient = new HttpClient();

		public async Task<string> jsonLoad()
        {
            string hell = "";

            try
            {
				Root resulteParse = await httpClient.GetFromJsonAsync<Root>("https://raw.githubusercontent.com/VanyaKpop/JsonFiles/main/Lessons_Din_219.json");
				var result =
					from i in resulteParse.Lesson
					where i.weekStart <= week && week <= i.weekEnd && i.idWeek == dayOfWeek && (i.even == null || i.even == (week % 2 == 0))

					orderby i.numeration
					select i;

				foreach (var item in result)
				{
					hell += $"{item.numeration}) {item.lesson} \n";
				}

				return hell;
			}
            catch
            {
				AssetManager assets = Android.App.Application.Context.Assets;

				using (StreamReader reader = new StreamReader(assets.Open("Lesson.json")))
				{
					var json = reader.ReadToEnd().ToString();
					Root resultParse = JsonConvert.DeserializeObject<Root>(json);

					var result =
						from i in resultParse.Lesson
						where i.weekStart <= week && week <= i.weekEnd && i.idWeek == dayOfWeek && (i.even == null || i.even == (week % 2 == 0))

						orderby i.numeration
						select i;

					foreach (var i in result)
					{
						hell += $"{i.numeration}.  {i.lesson} \n";
					}

					if (hell == null | hell == "")
						return "Сегодня выходной";
					else
						return hell;
				}
			}
            
        }

        public string jsonLoad(string weekNow, int week)
        {
            string hell = "";
            AssetManager assets = Android.App.Application.Context.Assets;

            using (StreamReader reader = new StreamReader(assets.Open("Lesson.json")))
            {
                var json = reader.ReadToEnd().ToString();
                Root resultParse = JsonConvert.DeserializeObject<Root>(json);

                var item = resultParse.Lesson;

                var result =
                    from i in item
                    where i.weekStart <= week && week <= i.weekEnd && i.idWeek == weekNow && (i.even == null || i.even == (week % 2 == 0))

                    orderby i.numeration
                    select i;

                foreach (var i in result)
                {
                    hell += $"{i.numeration}.  {i.lesson} \n";
                }

                return hell;
            }
        }
    }
    class Lesson
    {
        public string idWeek { get; set; }
        public int weekStart { get; set; }
        public int weekEnd { get; set; }
        public int? numeration { get; set; }
        public bool? even { get; set; }
        public string lesson { get; set; }
    }

    class Root
    {
        public List<Lesson> Lesson { get; set; }
    }

}