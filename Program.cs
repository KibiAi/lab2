using lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        Address myAddress = new Address();

        myAddress.Index = "1234";
        myAddress.Country = "Україна";
        myAddress.City = "Київ";
        myAddress.Street = "Вулиця Княжий Затон";
        myAddress.House = "3";
        myAddress.Apartment = "24";

        myAddress.DisplayAddressInfo();

        Console.ReadLine();


        //Employee
        Employee employee = new Employee("Стрижаков", "Віталій");

        string position = "Менеджер";
        int experience = 5;
        employee.DisplayEmployeeInfo(position, experience);

        Console.ReadLine();

        //User
        User user = new User("qwerty", "Віталій", "Стрижаков", 19);
        user.DisplayUserInfo();
        Console.ReadLine();

    }
}