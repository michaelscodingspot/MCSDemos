using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
    public class Serializer1
    {
        class Person
        {
            public string Name { get; set; }
        }

        public string Foo()
        {
            new log4net.Appender.AdoNetAppender();
            var person = new Person();
            var json = JsonConvert.SerializeObject(person);
            return json;
        }
    }
}
