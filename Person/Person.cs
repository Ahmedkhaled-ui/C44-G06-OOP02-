using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public struct Person
    {
        string Name;
        int Age;


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string name { get; set; }
        public int age { get; set; }
    }
    
    
}
