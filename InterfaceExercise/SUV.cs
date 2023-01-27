using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public SUV()
        {

        }

        //SUV Properties
        public string HornNoise { get; set; } = "Vroom!";
        public bool HasLiftDoor { get; set; } = true;

        public string Make { get; set; } 

        //ICompany properties
        public string CompanyName { get ; set ; }
        public bool HasLogo { get ; set ; }

        //IVehicle properties
        public int NumberOfWheels { get ; set ; }
        public int NumberOfSteeringWheels { get ; set ; }
        public bool HasBumper { get ; set ; }
        public string ModelName { get; set; }

    }
}
