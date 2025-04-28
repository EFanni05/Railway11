using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway11
{
    internal class Engine : Base
    {
        //id, mass, speed, towableMass
        double _towableMass;

        public Engine(string id, double mass, double speed, double towableMass) : base(id, mass, speed)
        {
            TowableMass = towableMass;
        }

        public double TowableMass { get => _towableMass; set => _towableMass = value; }
    }
}
