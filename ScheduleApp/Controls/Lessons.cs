using System.Reflection;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using ScheduleApp.Model;
using System.Net.Http;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace lessons
{
    class Lessons
    {

		private HttpClient httpClient = new HttpClient();
		public async Task<string> JsonLoad(string weekNow, int week)
        {
            string str = "";
			try
			{
				Root resulteParse = await httpClient.GetFromJsonAsync<Root>("https://raw.githubusercontent.com/VanyaKpop/JsonFiles/main/Lessons_Din_219.json");
				var result =
					from i in resulteParse.Lesson
					where i.weekStart <= week && week <= i.weekEnd && i.idWeek == weekNow && (i.even == null || i.even == (week % 2 == 0))

					orderby i.numeration
					select i;

				foreach (var item in result)
				{
					str += $"{item.numeration}) {item.lesson} - {item.time} \n";
				}

				return str;
			}
            catch
            {
				var assembly = IntrospectionExtensions.GetTypeInfo(typeof(Lessons)).Assembly;

				using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("ScheduleApp.Data.Lesson.json")))
				{
					var json = reader.ReadToEnd().ToString();
					Root resultParse = JsonConvert.DeserializeObject<Root>(json);

					var result =
						from i in resultParse.Lesson
						where i.weekStart <= week && week <= i.weekEnd && i.idWeek == weekNow && (i.even == null || i.even == (week % 2 == 0))

						orderby i.numeration
						select i;

					foreach (var i in result)
					{
						str += $"{i.numeration}.  {i.lesson} \n";
					}

					return str;
				}
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
        public string time { get; set; }
    }

    class Root
    {
        public List<Lesson> Lesson { get; set; }
    }

}
