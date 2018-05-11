using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Generics
{
    class Person : IComparable<Person>
    {
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Age < other.Age)
            {
                return -1;
            }
            else if (this.Age == other.Age)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
