using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway11
{
    //train maker
    internal class Vehicle
    {
        Engine _engine;
        List<PassengerCar> _pCarts;
        List<FreightCar> _fCars;

        public Vehicle(Engine engine)
        {
            Engine = engine;
            PCarts = new();
            FCarts = new();
        }

        public void AddCart(PassengerCar car)
        {
            PCarts.Add(car);
        }

        public void AddCart(FreightCar car)
        {
            FCarts.Add(car);
        }

        public override string ToString()
        {
            string a = Engine.Id == null ? "" : Engine.Id;
            if (PCarts.Count == 0)
            {
                foreach (PassengerCar car in PCarts)
                {
                    a += "+" + car.Id;
                }
            }
            else
            {
                foreach (FreightCar car in FCarts)
                {
                    a += "+" + car.Id;
                }
            }
            return a;
        }

        internal Engine Engine { get => _engine; set => _engine = value; }
        internal List<PassengerCar> PCarts { get => _pCarts; set => _pCarts = value; }
        internal List<FreightCar> FCarts { get => _fCars; set => _fCars = value; }
    }
}
