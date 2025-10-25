using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Abstract_class__Polymorphism__ForEach.Models
{
    internal class Car: Vehicle
    {
        private bool isAutomatic;
        private int trunkCapacity;
        private int doorsCount;

        public  int DoorsCount { get; set; }

        public int TrunkCapacity { get; set; }

        public bool IsAutomatic { get; init; }

        public int MaxSpeed { get; init; }
        public object DoorCount { get; private set; }
        public object TransmissionType { get; private set; }

        public Car(string brand, string model, int year, string plateNumber,
               int doorCount, int transmissionType, int isAutmatic, int maxSpeed, bool isAutomatic) : base(brand, model, year, plateNumber)
        {
            this.DoorsCount = doorsCount;
            this.TrunkCapacity = trunkCapacity;
            this.IsAutomatic = isAutomatic;
            this.MaxSpeed = maxSpeed;
            this.isAutomatic = isAutomatic;
        }
        public override void ShowCarInfo()
        {
            Console.WriteLine($"{GetVehicleInfo()} \n Model: {Model}\n Year: {Year}\n Palet Doors: {DoorCount}\n Transmission: {TransmissionType}\n");
        }

    }
}
