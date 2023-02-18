using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources.Extensions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Windows.Shapes;

namespace prac2sharp
{
    internal class generic
    {
        public static T deserializ<T>()
        {
            
            //File.Create("C:\\Users\\alinaryzhkova\\json.json");
            string json = File.ReadAllText("C:\\Users\\alinaryzhkova\\json.json");
            T json_text = JsonConvert.DeserializeObject<T>(json);
            return json_text;
        }

        public static void serializ <T>(T items_zametki)
        {

            string json = JsonConvert.SerializeObject(items_zametki);
            File.WriteAllText("C:\\Users\\alinaryzhkova\\json.json", json);
        }
    }
}