using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationDate = DateTime.Now;
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine("Інформація про користувача:");
            Console.WriteLine($"Логін: {login}");
            Console.WriteLine($"Ім'я: {firstName}");
            Console.WriteLine($"Прізвище: {lastName}");
            Console.WriteLine($"Вік: {age} років");
            Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
        }
    }
}
