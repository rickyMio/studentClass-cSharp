using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentClass
{
    class Student : Person
    {
        private string _section;
        public string section { get; set; }

        public Student(string name, string surname, int age, string section) : base(name, surname, age)
        {
            _section = section; 
        }
    }
}
