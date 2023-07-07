using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string Size { get; set; }

        public string Model { get; set; }

        public int Wheels { get; set; }

        public int Doors { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }
    }
}
