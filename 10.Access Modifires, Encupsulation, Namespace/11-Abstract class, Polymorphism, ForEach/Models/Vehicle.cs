using _11_Abstract_class__Polymorphism__ForEach.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _11_Abstract_class__Polymorphism__ForEach.Models
{
    internal class Vehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string PlateNumber { get; set; }

        public double FuelLevel { get; set; }


        public Vehicle(string brand, string model, int year, string plateNumber, double fuelLevel) 
        { 
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FuelLevel = 100;


        }

        public string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, Fuel Level: {FuelLevel}%";
        }
        public void ShowBasicInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Fuel Level: {FuelLevel}");
        }
        public 
    }


}


  











