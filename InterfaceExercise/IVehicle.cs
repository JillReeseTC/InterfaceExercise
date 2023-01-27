using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //Things in common in vehicles
        public int NumberOfWheels { get; set; }
        public int NumberOfSteeringWheels { get; set; }
        public string ModelName { get; set; }
        public string Make { get; set; }



    }
}
