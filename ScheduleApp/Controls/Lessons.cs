using System.Reflection;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace lessons
{
    class Lessons
    {
        public string JsonLoad(string weekNow, int week)
        {
            string str = "";

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
