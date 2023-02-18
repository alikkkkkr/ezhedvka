using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace prac2sharp
{
    class Myclass
    {
        public string name{ get; set; }
        public string opisan { get; set; }
        public string date { get; set; }  // object or datatime picker   мейби бейби

        public Myclass(string korob_name, string korob_opisan, string korob_date) 
        {
            name= korob_name;
            opisan= korob_opisan;
            date = korob_date;
        }

    }
}
