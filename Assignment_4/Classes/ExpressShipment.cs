using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;
using Assignment_4.Interfaces;

namespace Assignment_4.Classes
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set { extraFee = (value >= 0) ? value : extraFee; }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }

        public ExpressShipment(string tcode, string desc, decimal weight, decimal fee, DeliveryAddress destination, decimal extraFee)
            : base(tcode, desc, weight, fee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} KG");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee      : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
            Console.WriteLine("\n----------------------------------------");
        }

        public string GetTrackingStatus()
        {
            return $"\nShipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}