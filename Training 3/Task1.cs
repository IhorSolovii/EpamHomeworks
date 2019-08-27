using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
    }
    public class Task1
    {
        protected List<Person> list1;
        public Task1()
        {
            list1 = new List<Person>()
            {
                new Person { Name = "Ihor", Age = 22, PhoneNumbers = new string[] {"0937986538", "0987485738", "0638456387"}},
                new Person { Name = "Oleh", Age = 25, PhoneNumbers = new string[] {"0974567328", "0634785687", "0633876758"}},
                new Person { Name = "Andrew", Age = 20, PhoneNumbers = new string[] {"0973768465", "0634756867", "0936877564"}},
                new Person { Name = "Rostyk", Age = 29, PhoneNumbers = new string[] {"0634756857", "0975768493", "0634857685"}},
                new Person { Name = "Ivan", Age = 19, PhoneNumbers = new string[] {"0634657869", "0634651425", "0974856729"}},
                new Person { Name = "Roman", Age = 24, PhoneNumbers = new string[] {"0639065768", "0672654738", "0954654567"}}
            };
        }
        public virtual void DrawList()
        {
            foreach (var person in list1)
            {
                Console.WriteLine($"Name: {person.Name} \t/ Age: {person.Age}");
            }
        }
    }
}
