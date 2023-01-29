using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace InterfaceExercise
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicleList = new List<IVehicle>();

            List<Car> cars = new List<Car>();
            List<SUV> suvs = new List<SUV>();
            List<Truck> trucks = new List<Truck>();

            
            List<ICompany> companyList = new List<ICompany>();

            Car corolla = new Car()
            {
                IsPlugInElectric = false,
                Make = "Toyota",
                CompanyName = "Joe's Graphics",
                HasLogo = true,
                NumberOfWheels = 4,
                NumberOfSteeringWheels = 1,               
                ModelName = "Corolla"
            };
            
            vehicleList.Add(corolla);
            cars.Add(corolla);
            companyList.Add(corolla);

            Car prius = new Car();
            prius.CompanyName = "Creative Cookies";
            prius.HasLogo = false;          
            prius.IsPlugInElectric = true;
            prius.Make = "Toyota";
            prius.NumberOfWheels = 4;
            prius.NumberOfSteeringWheels = 1;            
            prius.ModelName = "Prius";

            vehicleList.Add(prius);
            cars.Add(prius);
            companyList.Add(prius);

            SUV highlander = new SUV()
            {
                CompanyName = "Creative Cookies",
                HasLogo = false,
                Make = "Toyota",
                ModelName = "Highlander",
                NumberOfSteeringWheels = 1,
                NumberOfWheels = 4,
                HasLiftDoor = true
            };

            vehicleList.Add(highlander);
            suvs.Add(highlander);
            companyList.Add(highlander);

            SUV jeep = new SUV()
            {
                CompanyName = "Eco Adventures!",
                HasLogo = true,
                Make = "Jeep",
                ModelName = "Grand Cherokee",
                NumberOfSteeringWheels = 1,
                NumberOfWheels = 4,
                HasLiftDoor = false,
                HornNoise = "WAAAH!"
            };

            vehicleList.Add(jeep);
            suvs.Add(jeep);
            companyList.Add(jeep);

            Truck dodge = new Truck()
            {
                CompanyName = "Eco Adventures!",
                HasLogo = true,
                Make = "Dodge",
                ModelName = "RAM 1500",
                NumberOfSteeringWheels = 1,
                NumberOfWheels = 4,
                HasTruckBed = true,
                HornNoise = "WHABEEP!"
            };

            vehicleList.Add(dodge);
            trucks.Add(dodge);
            companyList.Add(dodge);

            Truck hauler = new Truck()
            {
                CompanyName = "Tom's Towing",
                HasLogo = true,
                Make = "Ford",
                ModelName = "F450 Flatbed",
                NumberOfSteeringWheels = 1,
                NumberOfWheels = 4,
                HasTruckBed = false
            };

            vehicleList.Add(hauler);
            trucks.Add(hauler);
            companyList.Add(hauler);

            //vehicles.OfType<Car>() filters for the car types. can be used in foreach to get car or other vehicle trick
            /* foreach (var item in vehicleList)
            {
                string vehicleType = item.GetType().Name;
                string carMake = "";
            */

            foreach (var veh in vehicleList.OfType<Car>())
            {
                Console.Write($"{veh.Make} {veh.ModelName} is a {veh.GetType().Name} and has {veh.NumberOfWheels} wheels and");
                Console.WriteLine($" {veh.NumberOfSteeringWheels} steering wheel,");
                var electricHave = (veh.IsPlugInElectric) ? "does" : "does Not";
                Console.Write($" {electricHave} have plug-in electric,");
                Console.WriteLine($" and the horn noise is {veh.HornNoise}");
                var logo = (veh.HasLogo) ? "does" : "does Not";
                Console.WriteLine($"The car is owned by {veh.CompanyName} and {logo} have a logo on the vehicle. ");
                Console.WriteLine();
            }

            foreach (var veh in vehicleList.OfType<SUV>())
            {
                Console.Write($"{veh.Make} {veh.ModelName} is a {veh.GetType().Name} and has {veh.NumberOfWheels} wheels and");
                Console.WriteLine($" {veh.NumberOfSteeringWheels} steering wheel,");
                var liftDoor = (veh.HasLiftDoor) ? "does" : "does Not";
                Console.Write($" {liftDoor} have a rear lift door,");
                Console.WriteLine($" and the horn noise is {veh.HornNoise}");
                var logo = (veh.HasLogo) ? "does" : "does Not";
                Console.WriteLine($"The SUV is owned by {veh.CompanyName} and {logo} have a logo on the vehicle. ");
                Console.WriteLine();
            }

            foreach (var veh in vehicleList.OfType<Truck>())
            {
                Console.Write($"{veh.Make} {veh.ModelName} is a {veh.GetType().Name} and has {veh.NumberOfWheels} wheels and");
                Console.WriteLine($" {veh.NumberOfSteeringWheels} steering wheel,");
                var truckBed = (veh.HasTruckBed) ? "does" : "does Not";
                Console.Write($" {truckBed} have a truck bed,");
                Console.WriteLine($" and the horn noise is {veh.HornNoise}");
                var logo = (veh.HasLogo) ? "does" : "does Not";
                Console.WriteLine($"The truck is owned by {veh.CompanyName} and {logo} have a logo on the vehicle. ");
                Console.WriteLine();
            }

            /*
            foreach (var item in companyList)
            {

            }
            */

            /*
            var myCar = item.OfType<Car>();
            var electricHave = (myCar.IsPlugInElectric) ? "does" : "does Not";
            Console.WriteLine($" {electricHave} have plug-in electric.");


            //carMake = item.ModelName.ToLower();
            //int arrayCount = 0;
            foreach (var counter in cars)
            {
                Console.Write($"{item.Make} {item.ModelName}");
                //var electricHave = (counter.IsPlugInElectric) ? "does" : "does Not";
                Console.WriteLine($" {electricHave} have plug-in electric.");

            }
            */


        }
    }
}



