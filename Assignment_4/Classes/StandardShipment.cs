using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;
using Assignment_4.Interfaces;

namespace Assignment_4.Classes
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string tcode, string desc, decimal weight, decimal fee, DeliveryAddress destination)
            : base(tcode, desc, weight, fee, destination) { }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} KG");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
            Console.WriteLine("\n-----------------------------------------");
        }

        public string GetTrackingStatus()
        {
            return $"\nShipment {TrackingCode} is Ready.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}
