// See https://aka.ms/new-console-template for more information
using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Abstraction;
using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Encapsulation;
//using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Inheritance;

//using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Inheritance;
using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Polymorphism;

//Console.WriteLine("Hello, World!");
//BadBankAccount badBankAccount = new ();
//badBankAccount.balance = 100;

//BankAccount account = new(1000);
//var bal = account.GetBalance();
//Console.WriteLine(bal);

//EmailService emailService = new EmailService();
//emailService.SendEmail();
//Console.ReadLine();

//Car car = new Car();
//car.Brand = "Nissan";
//car.Year = 2020;
//car.Start();
//car.Stop();
//// unique
//car.NumberOfDoors = 4;

var vehicles = new List<Vehicle>();

Car car = new Car { Brand = "Toyota", Model ="Civic", Year = 1994};
Plane plane = new Plane();
Motorcycle motorcycle = new Motorcycle{Brand="Honda", Model="CBR1000", Year=2010};
vehicles.Add(car);
vehicles.Add(plane);
vehicles.Add(motorcycle);
//vehicle inspection

foreach (var vehicle in vehicles)
{
    vehicle.Start();
}

// above we are treating the objects in the same way even though they are in different forms



