using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int Wheels { get; set; }

        public int Doors { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

    }
}
