using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        //Instantiating
        public Truck() { }

        //Native Properties
        public bool HasBed {  get; set; }
        public string TypeOfSeats { get; set; }

        //Inherited Properties from IVehicle
        string IVehicle.Make { get; set; }
        string IVehicle.Model { get; set; }
        int IVehicle.Year { get; set; }
        string IVehicle.EngineSize { get; set; }

        //Inherited Properties from ICompany
        string ICompany.Name { get; set; }
        string ICompany.Logo { get; set; }
    }
}
