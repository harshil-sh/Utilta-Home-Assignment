using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PersonProcessor
    {
        /// <summary>
        /// The Value of GoodPersonPoints was too large and hence while 
        /// caluclating the sum, the it went out of the range of Int data type and
        /// hence I used type casting to int64 which can store such a large value.
        /// Int range: -2,147,483,648 to 2,147,483,647
        /// Int64 range (long): -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public static Int64 GetTotalGoodPersonPoints(List<Person> people)
        {
            return people.Sum(p => (Int64)p.GoodPersonPoints);
        }

        public static List<Person> PeopleBuilder()
        {
            Random random = new Random();
            var people = new List<Person>();
            var numberOfPeople = 100;

            for (int i = 0; i < numberOfPeople; i++)
            {
                if (i % 10 == 0) 
                {
                    people.Add(new Person
                    {
                        FullName = $"john smith{i}",
                        GoodPersonPoints = 514748005
                    });
                }

                people.Add(new Person
                {
                    FullName = $"john smith{i}",
                    GoodPersonPoints = random.Next(1, 100)
                });
            }

            return people;
        }
    }
}
