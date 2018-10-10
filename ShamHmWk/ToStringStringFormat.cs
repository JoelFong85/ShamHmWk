using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamHmWk
{
    public class Person
    {
        public string name { get; set; }
        public string age { get; set; }

        public Person(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return "Person: " + name + " " + age;
        }
    }



    class ToStringStringFormat
    {

        static void Main(string[] args)
        {
            Person p = new Person("Sham", "18");
            Console.WriteLine(p.ToString());
            Console.WriteLine(String.Format("Person is {0}", p));
            Console.WriteLine(String.Format("Person's name is {0} and her age is {1}", p.name, p.age));

        }



    }
}
