using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car() 
        {
        
        }
        //Car properties
        public bool IsPlugInElectric { get; set; } = false;
        public string HornNoise { get; set; } = "beep,beep!";

        //IVehicle Properties
        public int NumberOfWheels { get; set; }
        public int NumberOfSteeringWheels { get; set; }
        public string ModelName { get; set; }
        public string Make { get; set; }

        //ICOmpany Properties
        public string CompanyName { get; set; }
        public bool HasLogo { get; set; }
    }
}
