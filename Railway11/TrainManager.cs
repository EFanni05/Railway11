using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway11
{
    internal class TrainManager
    {
        List<Engine> engines;
        List<PassengerCar> passengerCars;
        List<FreightCar> freightCars;
        List<Vehicle> trains;

        public TrainManager()
        {
            Engines = new();
            PassengerCars = new();
            FreightCars = new();
        }

        internal List<Engine> Engines { get => engines; set => engines = value; }
        internal List<PassengerCar> PassengerCars { get => passengerCars; set => passengerCars = value; }
        internal List<FreightCar> FreightCars { get => freightCars; set => freightCars = value; }
        private List<Vehicle> Trains { get => trains; set => trains = value; }

        public void AddVehicle(Engine engine)
        {
            Engines.Add(engine);
        }

        public void AddVehicle(PassengerCar car)
        {
            PassengerCars.Add(car);
        }

        public void AddVehicle(FreightCar car)
        {
            FreightCars.Add(car);
        }

        public void RemoveVehicle(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    //engine check
                    if(Engines.Find(x => x.Id == id) != null)
                    {
                        int remove = Engines.FindIndex(x => x.Id == id);
                        Engines.RemoveAt(remove);
                    }
                    //passenger check
                    else if(PassengerCars.Find(x => x.Id == id) != null)
                    {
                        int remove = PassengerCars.FindIndex(x => x.Id == id);
                        PassengerCars.RemoveAt(remove);
                    }
                    //freight 
                    else if (FreightCars.Find(x => x.Id == id) != null)
                    {
                        int remove = FreightCars.FindIndex(x => x.Id == id);
                        FreightCars.RemoveAt(remove);
                    }
                    else
                    {
                        throw new Exception("Train not found");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        public bool CoupleSet(Engine engine, List<PassengerCar>? passengers, List<FreightCar>? freights)
        {
            try
            {
                if(engine != null)
                {
                    Vehicle vehicle = new(engine);
                    //cart number check
                    if(passengers.Count != 0 || passengers != null)
                    {
                        foreach (var cart in passengers)
                        {
                            //cart which exists in our database
                            if(PassengerCars.Find(x => x.Id == cart.Id) != null)
                            {
                                vehicle.AddCart(cart);
                            }
                        }
                    }
                    if(freights.Count != 0 || freights != null)
                    {
                        foreach (var cart in freights)
                        {
                            //cart which exists in our database
                            if (FreightCars.Find(x => x.Id == cart.Id) != null)
                            {
                                vehicle.AddCart(cart);
                            }
                        }
                    }
                    //final check
                    if(vehicle.PCarts.Count >= 1 || vehicle.FCarts.Count >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("No carts were added");
                    }
                }
                else
                {
                    throw new Exception("Error while making trains");
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                return false;
            }
        }

        public void PrintTrainSets()
        {
            foreach (var train in trains)
            {
                Console.WriteLine(trains.ToString());
            }
        }

        public void DecoupleSet(Vehicle vehicle)
        {
            var a = Trains.Find(x => x == vehicle);
            if (a != null) 
            {
                Trains.Remove(a);
            }
            else
            {
                Console.WriteLine("Trainset not found");
            }
        }

        public Vehicle? SearchSet(string? idEngine)
        {
            if (string.IsNullOrEmpty(idEngine))
            {
                return null;
            }
            return Trains.Find(x => x.Engine.Id == idEngine) == null ? null : Trains.Find(x => x.Engine.Id == idEngine);
        }

        public void Print()
        {
            Console.WriteLine("I like trains :)");
        }
    }
}
