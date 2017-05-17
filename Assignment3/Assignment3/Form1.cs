using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public class Vehicle
        {
            public Vehicle () { }

            public Vehicle (string manufacturer, string model, int makeYear, string registrationNo)
            {
                Manufacturer = manufacturer;
                Model = model;
                MakeYear = makeYear;
                RegistrationNo = registrationNo;
            }
            
            public void AddJourney (Journey journey)
            {
                Journeys.Add(journey);
            }

            public void AddFuelPurchase (FuelPurchase fuelPurchase)
            {
                FuelPurchases.Add(fuelPurchase);
            }

            public string PrintToScreen()
            {
                return ""; // replace "" with string to return
            }

            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public int MakeYear { get; set; }
            public string RegistrationNo { get; set; }

            public List<Journey> Journeys { get; set; }
            public List<FuelPurchase> FuelPurchases { get; set; }
        }

        public class Journey
        {
            Journey (double distanceTravelled, double fuelUsed)
            {
                DistanceTravelled = distanceTravelled;
                FuelUsed = fuelUsed;
            }

            public double DistanceTravelled { get; set; }
            public double FuelUsed { get; set; }
        }

        public class FuelPurchase
        {
            FuelPurchase (double fuelQuantityPurchased, double fuelCost)
            {
                FuelQuantityPurchased = fuelQuantityPurchased;
                FuelCost = fuelCost;
            }

            public double FuelQuantityPurchased { get; set; }
            public double FuelCost { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
