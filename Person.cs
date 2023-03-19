using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using helloWorld;

namespace helloWorld
{
    public class Person
    {
        // Fields
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _height;

        // Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        
        // Constructors
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = 0;
        }

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        // Methods
        public void Greet()
        {
            Console.WriteLine("Hello, my name is " + _firstName + " " + _lastName + ".");
        }

        public bool IsAdult()
        {
            return _age >= 18;
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
        public void AddToHeight() {
            Height += 1.0;
        }
    }

}



