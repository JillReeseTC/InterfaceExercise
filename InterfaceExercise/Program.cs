using System;
using System.Collections.Generic;
using System.ComponentModel;
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



            foreach (var item in vehicleList) 
            {   
                string vehicleType = item.GetType().Name;
                string carMake = "";
                Console.WriteLine($"{item.ModelName} is a {vehicleType}");
                if (vehicleType == "Car")
                {
                    carMake = item.ModelName.ToLower();
                    int arrayCount = 0;
                    foreach (var counter in cars)
                    {
                        Console.WriteLine($"{counter.Make} {item.ModelName}");
                    }
                   
                }


            }

        }
    }
}



