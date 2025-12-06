// See https://aka.ms/new-console-template for more information
using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Abstraction;
using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Coupling;
using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Encapsulation;
//using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Inheritance;

//using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Inheritance;
using DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Polymorphism;
using Microsoft.Extensions.DependencyInjection;



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

//var vehicles = new List<Vehicle>();

//Car car = new Car { Brand = "Toyota", Model ="Civic", Year = 1994};
//Plane plane = new Plane();
//Motorcycle motorcycle = new Motorcycle{Brand="Honda", Model="CBR1000", Year=2010};
//vehicles.Add(car);
//vehicles.Add(plane);
//vehicles.Add(motorcycle);
////vehicle inspection

//foreach (var vehicle in vehicles)
//{
//    vehicle.Start();
//}

// above we are treating the objects in the same way even though they are in different forms

// this is the example of coupling below

//var services = new ServiceCollection();

//services.AddScoped<INotificationService, SmsSender>();
//// can use the email service instead above
//services.AddScoped<IOrder, Order>();

//var serviceProvider = services.BuildServiceProvider();

//var OrderService = serviceProvider.GetService<IOrder>();


//OrderService.PlaceOrder();
//Console.ReadLine();

//var rectangle = new DesignPatternsSOLID_OOPInCSharp.SOLID.L.Bad.Rectangle();
//rectangle.Width = 5;
//rectangle.Height = 10;
//Console.WriteLine("Area Should Be 50");
//Console.WriteLine($"Rectangle Area: {rectangle.Area}");
//var squareBad = new DesignPatternsSOLID_OOPInCSharp.SOLID.L.Bad.Square();
//squareBad.Width = 5;
//Console.WriteLine($"Square Area: {squareBad.Area}");
// this will print 25 instead of 50
// because setting the width also sets the height
// violating the Liskov Substitution Principle
// because a square is not a rectangle
// in terms of behavior
// even though it is a rectangle in terms of shape
// this is a classic example of LSP violation
// to fix this we can create a separate class for Square
// that does not inherit from Rectangle
// or we can use composition instead of inheritance
// to model the relationship between Square and Rectangle
// thus adhering to LSP

//var squareGood = new DesignPatternsSOLID_OOPInCSharp.SOLID.L.Good.Square();
//squareGood.SideLength = 5;
//Console.WriteLine("Area Should Be 25");
//Console.WriteLine($"Square Area: {squareGood.Area}");

// this adheres to LSP
// because Square does not inherit from Rectangle
// thus we can use both classes interchangeably
// without any unexpected behavior
// even though they are both shapes
// they have different implementations for calculating areal

// examples for Interface Segregation Principle

var circleBad = new DesignPatternsSOLID_OOPInCSharp.SOLID.I.Bad.CircleBad();
circleBad.Radius = 5;
Console.WriteLine("Area Should Be 78.54");
Console.WriteLine($"Circle Area: {circleBad.Area()}");
// the following line will throw an exception
// because CircleBad does not support Volume method

//Console.WriteLine($"Circle Volume: {circleBad.Volume()}");

