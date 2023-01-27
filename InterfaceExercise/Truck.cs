using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public Truck() 
        { 
        
        }
        //Truck class members
        public string HornNoise { get; set; } = "GETOUTOFMYWAY!";
        public bool HasTruckBed { get; set; } = true;

        //ICompany class members
        public string CompanyName { get ; set ; }
        public bool HasLogo { get ; set ; }

        //IVehicle class members
        public int NumberOfWheels { get ; set ; }
        public int NumberOfSteeringWheels { get ; set ; }
        public string ModelName { get; set; }
        public string Make { get; set; }

    }
}
