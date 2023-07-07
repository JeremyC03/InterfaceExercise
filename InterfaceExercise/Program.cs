using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            List<Car> carList = new List<Car>();
            Car car = new Car()
            { 
                Wheels = 4, 
                Doors = 4, 
                Color = "Red", 
                Year = 2012, 
                Name = "Toyota", 
                Logo = "T-shaped steering wheel", 
                Size = "Small",
                Model = "Corola S"
            };
            carList.Add(car);

            foreach (Car item in carList)
            {
                Console.WriteLine($"Number of wheels: {item.Wheels}");
                Console.WriteLine($"Number of doors: {item.Doors}");
                Console.WriteLine($"Color of car: {item.Color}");
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Name of Company: {item.Name}");
                Console.WriteLine($"Logo: {item.Logo}");
                Console.WriteLine($"Size of car: {item.Size}");
                Console.WriteLine($"Model of car: {item.Model}");
                Console.WriteLine();
            }

            List<Truck> truckList = new List<Truck>();
            Truck truck = new Truck()
            {
                Wheels = 4,
                Doors = 2,
                Color = "White",
                Year = 2016,
                Name = "Chevrolet",
                Logo = "Stylized cross",
                Size = "Large",
                Model = "Tornado"
            };
            truckList.Add(truck);

            foreach (Truck item in truckList)
            {
                Console.WriteLine($"Number of wheels: {item.Wheels}");
                Console.WriteLine($"Number of doors: {item.Doors}");
                Console.WriteLine($"Color of truck: {item.Color}");
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Name of Company: {item.Name}");
                Console.WriteLine($"Logo: {item.Logo}");
                Console.WriteLine($"Size of truck: {item.Size}");
                Console.WriteLine($"Model of truck: {item.Model}");
                Console.WriteLine();
            }

            List<SUV> suvList = new List<SUV>();
            SUV suv = new SUV()
            {
                Wheels = 4,
                Doors = 4,
                Color = "Black",
                Year = 2019,
                Name = "Subaru",
                Logo = "Six stars",
                Size = "Medium",
                Model = "Outback"
            };
            suvList.Add(suv);

            foreach (SUV item in suvList)
            {
                Console.WriteLine($"Number of wheels: {item.Wheels}");
                Console.WriteLine($"Number of doors: {item.Doors}");
                Console.WriteLine($"Color of SUV: {item.Color}");
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Name of Company: {item.Name}");
                Console.WriteLine($"Logo: {item.Logo}");
                Console.WriteLine($"Size of SUV: {item.Size}");
                Console.WriteLine($"Model of SUV: {item.Model}");
                Console.WriteLine();
            }
        }
    }
}
