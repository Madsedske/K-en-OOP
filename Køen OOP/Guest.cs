using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen_OOP
{
    class Guest
    {
        private string name;
        private int age;

        public Guest()
        {          
        }

        public Guest(int Age, string Name)
        {
            age = Age;
            name = Name;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        

    }
}
