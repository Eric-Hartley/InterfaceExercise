using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int Year { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public string EngineSize { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();

    }
}
