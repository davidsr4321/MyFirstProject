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
        private string _pet_name;
        private double _height;
        private string _my_color;
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


        public string PetName
        {
            get { return _pet_name; }
            set { _pet_name = value; }

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
            return _firstName + "and" + _lastName;
        }
<<<<<<< HEAD
        
=======
        public void AddToHeight() {
            Height += 1.0;
        }
>>>>>>> 248d42c55df754df9f7547fc71bc1e5eea6ec66f
    }

}



