using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;


namespace InterfaceExercise
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicleList = new List<IVehicle>();

            int carcount = 0;
            int suvCount = 0;
            int truckCount = 0;

            List<Car> cars = new List<Car>();
            
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
            carcount++;
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
            carcount++;
            companyList.Add(prius);




            //vehicles.OfType<Car>() filters for the car types. can be used in foreach to get car or other vehicle trick
            /* foreach (var item in vehicleList)
            {
                string vehicleType = item.GetType().Name;
                string carMake = "";
                Console.Write($"{item.ModelName} is a {vehicleType} and has {item.NumberOfWheels} wheels and");
                Console.WriteLine($" {item.NumberOfSteeringWheels} steering wheel.");
               // var logoHave = (item.HasLogo) ? "does" : "does Not";
               // carMake = item.ModelName.ToLower();
               // Console.WriteLine($"The car belongs to {carMake.CompanyName}");

                //if (vehicleType == "Car")   */

                foreach (var veh in vehicleList.OfType<Car>())
                {
                    Console.Write($"{veh.Make} {veh.ModelName} is a {veh.GetType().Name} and has {veh.NumberOfWheels} wheels and");
                    Console.WriteLine($" {veh.NumberOfSteeringWheels} steering wheel.");
                    var electricHave = (veh.IsPlugInElectric) ? "does" : "does Not";
                    Console.Write($" {electricHave} have plug-in electric,");
                    Console.WriteLine($" and the horn noise is {veh.HornNoise}");
                    Console.WriteLine();




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


          //  }

        }
    }
}



