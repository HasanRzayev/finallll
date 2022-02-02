using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit
{
    class Client
    {
        public Client(string name, int age, string job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }

        public string name { get; set; }
        public int age { get; set; }
        public string job { get; set; }

    }
}
