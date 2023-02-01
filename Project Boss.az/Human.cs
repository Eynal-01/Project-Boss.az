using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Boss_az
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Human(string name, string surname, string city, int age, string username, string password)
        {
            Name = name;
            Surname = surname;
            City = city;
            Age = age;
            Username = username;
            Password = password;
        }
        public Human() { }

        public void ShowHuman()
        {
            Console.WriteLine($"\t\t\t\t\t\t\tName : {Name}");
            Console.WriteLine($"\t\t\t\t\t\t\tSurname : {Surname}");
            Console.WriteLine($"\t\t\t\t\t\t\tAge : {Age}");
            Console.WriteLine($"\t\t\t\t\t\t\tCity : {City}");
        }
    }
}
