using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public double CalculateSalary(string position, int experience)
        {
            double baseSalary = 0;

            switch (position.ToUpper())
            {
                case "МЕНЕДЖЕР":
                    baseSalary = 30000;
                    break;
                case "ПРОГРАМІСТ":
                    baseSalary = 40000;
                    break;
                case "БУХГАЛТЕР":
                    baseSalary = 35000;
                    break;
                default:
                    throw new ArgumentException("Непідтримувана посада");
            }

            double experienceBonus = experience * 500;

            double totalSalary = baseSalary + experienceBonus;

            return totalSalary;
        }

        public double CalculateTax(double salary)
        {
            double tax = salary * 0.18;
            return tax;
        }

        public void DisplayEmployeeInfo(string position, int experience)
        {
            Console.WriteLine($"Прізвище: {lastName}");
            Console.WriteLine($"Ім'я: {firstName}");
            Console.WriteLine($"Посада: {position}");
            double salary = CalculateSalary(position, experience);
            Console.WriteLine($"Оклад: {salary} грн");
            double tax = CalculateTax(salary);
            Console.WriteLine($"Податковий збір: {tax} грн");
        }
    }
}



