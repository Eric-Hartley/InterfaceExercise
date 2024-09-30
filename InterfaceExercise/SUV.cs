using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        //Native Properties
        public int NumberOfSeats { get; set; }
        public int NumberOfRows { get; set; }

        //Inherited Properties from IVehicle
        int IVehicle.NumberOfWheels { get; set; }
        string IVehicle.EngineType { get; set; }
        int IVehicle.NumberOfDoors { get; set; }
        string IVehicle.GasType { get; set; }

        //Inherited Properties from ICompany
        string ICompany.Name { get; set; }
        string ICompany.Logo {  get; set; }    

    }
}
