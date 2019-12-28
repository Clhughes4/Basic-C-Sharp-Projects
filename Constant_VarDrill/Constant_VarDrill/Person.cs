using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_VarDrill
{
    class Person
    {
        private const string place = "New";
        private string name;
        private int id;
       
        public Person (int id) :this(id, "")
        {
        }
        public Person (int id, string name) 
        {
            var person = "John";
            this.id = id;
            this.name = name;
        }
       
    }
}
