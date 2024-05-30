using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentifier
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;
        public int Age 
        {
            get { return age; } 
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Age must be greater then 0.");
                }
                age = value;
            } 
        }
        public string FName 
        { 
            get { return fName; } 
            set 
            {
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentException("First name is requierd.");
                }
               else if (value.Length < 2 || value.Length > 10) 
                {
                    throw new ArgumentException("First name must be between 2 and 10 char.");
                }
                fName = value; 
            } 
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name is requierd.");
                }
                else if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must be between 3 and 15 char.");
                }
                lName = value;
            }
        }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
    }
}
