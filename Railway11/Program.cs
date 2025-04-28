namespace Railway11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Példányosítsa a nyilvántartást
            TrainManager trainManager = new TrainManager();

            //Engines
            Engine m31 = new Engine("M31", 3, 20, 11);//id, mass, speed, towableMass
            Engine m41 = new Engine("M41", 30, 100, 250);
            Engine m47 = new Engine("M47", 26, 70, 180);

            //Adja hozzá a nyilvántartáshoz itt a fenti mozdonyokat
            trainManager.AddVehicle(m31);
            trainManager.AddVehicle(m41);
            trainManager.AddVehicle(m47);

            //Freight cars
            FreightCar eas1 = new FreightCar("Eas1", 8, 60, 10); //id, mass, speed, capacity
            FreightCar eas2 = new FreightCar("Eas2", 8, 60, 10);
            FreightCar eas3 = new FreightCar("Eas3", 8, 60, 10);
            FreightCar eas4 = new FreightCar("Eas4", 8, 60, 10);
            FreightCar ks1 = new FreightCar("Ks1", 4, 80, 12);
            FreightCar ks2 = new FreightCar("Ks2", 4, 80, 12);
            FreightCar ks3 = new FreightCar("Ks3", 4, 80, 12);
            FreightCar ks4 = new FreightCar("Ks4", 4, 80, 12);

            //Adja hozzá a nyilvántartáshoz a fenti tehervagonokat
            trainManager.AddVehicle(eas1);
            trainManager.AddVehicle(eas2);
            trainManager.AddVehicle(eas3);
            trainManager.AddVehicle(eas4);
            trainManager.AddVehicle(ks1);
            trainManager.AddVehicle(ks2);
            trainManager.AddVehicle(ks3);
            trainManager.AddVehicle(ks4);

            //Passenger cars
            PassengerCar Bhv1 = new PassengerCar("Bhv1", 13, 100, 80); //id, mass, speed, passengerNumber
            PassengerCar Bhv2 = new PassengerCar("Bhv2", 13, 100, 80);
            PassengerCar Bhv3 = new PassengerCar("Bhv3", 13, 100, 80);
            PassengerCar ARp = new PassengerCar("ARp", 15, 120, 60);
            PassengerCar Bp1 = new PassengerCar("Bp1", 11, 120, 70);
            PassengerCar Bp2 = new PassengerCar("Bp2", 11, 120, 70);
            PassengerCar Bp3 = new PassengerCar("Bp3", 11, 120, 70);
            PassengerCar Bp4 = new PassengerCar("Bp4", 11, 120, 70);

            //Adja hozzá a nyilvántartáshoz a fenti személyvagonokat
            trainManager.AddVehicle(Bhv1);
            trainManager.AddVehicle(Bhv2);
            trainManager.AddVehicle(Bhv3);
            trainManager.AddVehicle(ARp);
            trainManager.AddVehicle(Bp1);
            trainManager.AddVehicle(Bp2);
            trainManager.AddVehicle(Bp3);
            trainManager.AddVehicle(Bp4);

            //Írassa ki a konzolra a nyilvántartott járműveket
            trainManager.Print();
            Console.WriteLine();

            //Készítse el a következő szerelvényeket
            //M31+Ks1+Ks2+Ks3
            bool set1 = trainManager.CoupleSet(m31, null, new List<FreightCar>{ks1,ks2,ks3});
            Console.WriteLine($"Az M31+Ks1+Ks2+Ks3 szerelvény létrehozása: {set1}");

            //M41+ARp+Bp1+Bp3+Bhv1+Bhv3
            bool set2 = trainManager.CoupleSet(m41, new List<PassengerCar>{ARp,Bp1,Bp3,Bhv1,Bhv3}, null);
            Console.WriteLine($"Az M41+ARp+Bp1+Bp3+Bhv1+Bhv3 szerelvény létrehozása: {set2}");

            //M47+Eas1+Eas2+Eas3+Eas4+Ks4
            bool set3 = trainManager.CoupleSet(m47, null, new List<FreightCar>{eas1,eas2,eas3,eas4});
            Console.WriteLine($"Az M47+Eas1+Eas2+Eas3+Eas4+Ks4 szerelvény létrehozása: {set3}");
            Console.WriteLine();

            //Írassa ki a konzolra a szerelvényeket
            trainManager.PrintTrainSets();
            Console.WriteLine();

            //Bontsa fel az M47+Eas1+Eas2+Eas3+Eas4+Ks4 öszeállítást és selejtezze az Eas1-3 kocsikat
            Vehicle trainSet = trainManager.SearchSet("M47");
            trainManager.DecoupleSet(trainSet);

            //Írassa ki a konzolra a szerelvényeket
            trainManager.PrintTrainSets();
            Console.WriteLine();

            trainManager.RemoveVehicle("eas1");
            trainManager.RemoveVehicle("eas2");
            trainManager.RemoveVehicle("eas3");

            //Írassa ki a konzolra a járműveket
            trainManager.Print();
            Console.WriteLine();
        }
    }
}
