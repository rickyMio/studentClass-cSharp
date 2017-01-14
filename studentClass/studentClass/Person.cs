
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentClass
{
    class Person
    {
        private string _name;
        public string name { get; set; }

        private string _surname;
        public string surname { get; set; }

        private int _age;
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }
                _age = value;
            }
        }

        public string cf
        {
            get
            {
                return name + surname + age;
            }
        }

        public Person(string name, string surname, int age)
        {
            _name    = name;
            _surname = surname;
            _age     = age;
        }
        
        public string describe()
        {
            string output = "NOME:       " + name    + "\r\n";
            output       += "COGNOME:    " + surname + "\r\n";
            output       += "ETA':       " + age     + "\r\n";
            output       += "C. FISCALE: " + cf;

            return output;
        }
    }
}
