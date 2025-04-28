using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway11
{
    public abstract class Base
    {
        string _id;
        double _mass;
        double _speed;

        public Base(string id, double mass, double speed)
        {
            Id = id;
            Mass = mass;
            Speed = speed;
        }

        public string Id { get => _id; set => _id = value; }
        public double Mass { get => _mass; set => _mass = value; }
        public double Speed { get => _speed; set => _speed = value; }
    }
}
