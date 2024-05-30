using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentifier
{
    internal class PersonHandlar
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            var person = new Person
            {
                Age = age,
                FName = fName,
                LName = lName,
                Weight = weight,
                Height = height
            };
            return person;
        }

        public void SetFirstName(Person person, string fName)
        {
            person.FName = fName;
        }
        
        public void SetLastName(Person person, string lName)
        {
            person.LName = lName;
        }
        
        public void SetWeight(Person person, int weight)
        {
            person.Weight = weight;
        }
        
        public void SetHeight(Person person, int height)
        {
            person.Height = height;
        }
        
        public int GetAge(Person person)
        {
            return person.Age;
        }
        
        public string GetFirstName(Person person)
        {
            return person.FName;
        }
        
        public string GetLastName(Person person)
        {
            return person.LName;
        }

        public double GetWeight(Person person)
        {
          return person.Weight;
        }

        public double GetHeight(Person person)
        {
            return person.Height;
        }
    }
}
