using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShayTest
{
    public class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(int _id, string f_name, string l_name)
        {

            Id = _id;
            FirstName = f_name;
            LastName = l_name;
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}\n"; 
        }
    }
}
