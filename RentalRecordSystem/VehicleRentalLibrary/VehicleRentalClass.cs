using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalLibrary
{
    public class Vehicle
    {
        public Vehicle() { }

        public Vehicle(string manufacturer, string model, int makeYear, string registrationNo)
        {
            Manufacturer = manufacturer;
            Model = model;
            MakeYear = makeYear;
            RegistrationNo = registrationNo;
        }

        public void AddJourney(double distanceTravelled)
        {
            Journeys.Add(new Journey(distanceTravelled));
        }

        public void AddFuelPurchase(double fuelQuantityPurchased, double fuelCostPerL)
        {
            FuelPurchases.Add(new FuelPurchase(fuelQuantityPurchased, fuelCostPerL));
        }

        public void AddService()
        {
            Services.Add(new Service(CalculateTotalDistanceTravelled()));
        }

        public void AddPerKmRental(double kmTravelled)
        {
            PerKmRentals.Add(new PerKmRental(kmTravelled));
        }

        public void AddPerDayRental(int daysRented)
        {
            PerDayRentals.Add(new PerDayRental(daysRented));
        }

        public double CalculateTotalDistanceTravelled()
        {
            double totalDistance = 0;
            // add all journeys distances
            foreach (Journey j in Journeys)
            {
                totalDistance = totalDistance + j.DistanceTravelled;
            }
            return totalDistance;
        }

        public double CalculateTotalRevenue()
        {
            double Total = 0;
            // add all revenue from Per Km Rentals
            foreach (PerKmRental km in PerKmRentals)
            {
                Total = Total + km.CalculateRentalCost();
            }
            // add all revenue from Per Day Rentals
            foreach (PerDayRental d in PerDayRentals)
            {
                Total = Total + d.CalculateRentalCost();
            }
            // subtract all fuel costs from revenue
            foreach (FuelPurchase f in FuelPurchases)
            {
                Total = Total - f.CalculateFuelCost();
            }
            return Total;
        }

        public double CalculateDistanceSinceLastService()
        {
            if (Services.Count > 0)
            {
                // calculate distance since last service
                return CalculateTotalDistanceTravelled() - Services.Last().TotalKmTravelled;
            }
            else
            {
                return CalculateTotalDistanceTravelled();
            }
        }

        public double CalculateFuelEconomy()
        {
            double FuelUsed = 0;
            // calculate fuel used
            foreach (FuelPurchase f in FuelPurchases)
            {
                FuelUsed = FuelUsed + f.FuelQuantityPurchased;
            }
            // prevent divide by zero
            if (FuelUsed > 0 && CalculateTotalDistanceTravelled() > 0)
            {
                // calculate fuel economy
                return (CalculateTotalDistanceTravelled() / FuelUsed) / 100;
            }
            else
            {
                return 0;
            }
        }

        public bool IsServiceRequired()
        {
            if (CalculateDistanceSinceLastService() >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PrintToScreen()
        {
            return "Manufacturer: " + Manufacturer + Environment.NewLine +
                "Model: " + Model + Environment.NewLine +
                "Make Year: " + MakeYear + Environment.NewLine +
                "Registration No: " + RegistrationNo + Environment.NewLine +
                "Total Kilometres Travelled: " + CalculateTotalDistanceTravelled() + Environment.NewLine +
                "Total Services: " + Services.Count + Environment.NewLine +
                "Revenue recorded: $" + CalculateTotalRevenue().ToString("f2") + Environment.NewLine +
                "Kilometres since the last service: " + CalculateDistanceSinceLastService() + Environment.NewLine +
                "Fuel economy: " + ((CalculateFuelEconomy() > 0) ? (CalculateFuelEconomy().ToString("f2") + "L/100Km") : "--") + Environment.NewLine + // display fuel economy or '--' if fuel economy unavalible
                "Requires a service: " + (IsServiceRequired() ? "Yes" : "No"); // convert bool response to yes or no
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int MakeYear { get; set; }
        public string RegistrationNo { get; set; }


        public List<Journey> Journeys = new List<Journey>();
        public List<FuelPurchase> FuelPurchases = new List<FuelPurchase>();
        public List<Service> Services = new List<Service>();
        public List<PerKmRental> PerKmRentals = new List<PerKmRental>();
        public List<PerDayRental> PerDayRentals = new List<PerDayRental>();
    }

    public class Journey
    {
        public Journey(double distanceTravelled)
        {
            DistanceTravelled = distanceTravelled;
        }

        public double DistanceTravelled { get; set; }
    }

    public class FuelPurchase
    {
        public FuelPurchase(double fuelQuantityPurchased, double fuelCostPerL)
        {
            FuelQuantityPurchased = fuelQuantityPurchased;
            FuelCostPerL = fuelCostPerL;
        }

        public double CalculateFuelCost()
        {
            // Calculate Fuel Cost
            return FuelCostPerL * FuelQuantityPurchased;
        }

        public double FuelQuantityPurchased { get; set; }
        public double FuelCostPerL { get; set; }
    }

    public class PerKmRental
    {
        public PerKmRental(double kmTravelled)
        {
            KmTravelled = kmTravelled;
        }

        public double CalculateRentalCost()
        {
            // Calculate Rental Cost
            return KmTravelled * ChargingRate;
        }

        public double KmTravelled { get; set; }
        public double ChargingRate { get; set; } = 1;
    }

    public class PerDayRental
    {
        public PerDayRental(int daysRented)
        {
            DaysRented = daysRented;
        }

        public double CalculateRentalCost()
        {
            return DaysRented * ChargingRate;
        }

        public int DaysRented { get; set; }
        public double ChargingRate { get; set; } = 100;
    }

    public class Service
    {
        public Service(double totalKmTravelled)
        {
            TotalKmTravelled = totalKmTravelled;
        }
        public double TotalKmTravelled { get; set; }
    }

}
