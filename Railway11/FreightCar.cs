using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway11
{
    internal class FreightCar : Base
    {
        //id, mass, speed, capacity
        int _capacity;

        public FreightCar(string id, double mass, double speed, int capacity) : base(id, mass, speed)
        {
            Capacity = capacity;
        }

        public int Capacity { get => _capacity; set => _capacity = value; }
    }
}
