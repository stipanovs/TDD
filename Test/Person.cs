using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        // for test
        public const string AgeLessThanZero = "AgeLessThanZero";

        public Person(string firstName, int age)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException("First name is null or whitespace ");
            }
            else
            {
                firstName = firstName;
            }

            if(age < 0)
            {
                throw new ArgumentOutOfRangeException("Age is less than zero!", age, AgeLessThanZero);
                Age = 0;
            }
            else
            {
                Age = age;
            }
        }

    }
}
