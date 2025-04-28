using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway11
{
    internal class PassengerCar : Base
    {
		//id, mass, speed, capacity
		int _passengers;

        public PassengerCar(string id, double mass, double speed, int capacity) : base(id, mass, speed)
        {
            Passengers = capacity;
        }

        public int Passengers { get => _passengers; set => _passengers = value; }
    }
}
