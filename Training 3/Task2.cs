using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_3
{
    public class Task2 : Task1
    {
        List<Person> list2;
        public Task2() : base()
        {
            list2 = new List<Person>
            {
                new Person { Name = "Serhiy", Age = 26, PhoneNumbers = new string[] { "0634758679", "0634672847", "0975763524"}},
                new Person { Name = "Pavlo", Age = 35, PhoneNumbers = new string[] { "0976078567", "0673453267", "0673423456"}}
            };
            base.list1.AddRange(list2);
        }
        public override void DrawList()
        {
            foreach (var person in base.list1)
            {
                Console.Write($"Name: {person.Name} \t/ Age: {person.Age} / Number: ");
                foreach (var number in person.PhoneNumbers)
                {
                    Console.Write($"{number}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
