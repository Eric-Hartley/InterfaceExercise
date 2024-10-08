using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        //instantiating
        public Car() { }


        //Inherited Properties from IVehicle
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";
        public int SeatCount { get; set; } = 0;
        public double EngineSize { get; set; } = 0;


        //Inherited Properties from ICompany
        public string Name { get; set; } = "Insert Company Name";
        public string Motto { get; set; } = "Insert Motto";
        public bool HasChangedGears { get ; set; }
        

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} driving");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} parked");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Change gear");
            }
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Change gear");
            }
            
        }
        public void ChangeGear(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
