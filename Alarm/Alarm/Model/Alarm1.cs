using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Alarm.Model
{
    class Alarm1
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set;}
        public string alarm { get; set;}
        public string time { get; set;}
        public string repeat { get; set;}
        public string days { get; set;}
    }
}
