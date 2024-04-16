using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;
using System.Linq;


namespace lessons
{
    class Lessons
    {

        public string JsonLoad(string weekNow, int week, Stream stream)
        {
            string hell = "";

            using (StreamReader reader = new StreamReader(stream))
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