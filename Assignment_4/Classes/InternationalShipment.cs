using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{

    public class InternationalShipment : Shipment
    {
        private string destinationCountry = "Unknown";
        private decimal customsFee;


        public string DestinationCountry
        {
            get { return destinationCountry; }
            set { if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }


        public decimal CustomsFee
        {
            get { return customsFee; }
            set { customsFee = (value >= 0) ? value : customsFee; }
        }


        public override decimal EstimatedCost
        {
            get{ return base.EstimatedCost + CustomsFee; }
        }


        public InternationalShipment(string tcode, string desc, decimal weight, decimal fee, DeliveryAddress destination, string country,
            decimal customsFee) : base(tcode, desc, weight, fee, destination)
        {
            DestinationCountry = country;
            CustomsFee = customsFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
            Console.WriteLine("\n-------------------------------------------");
        }
    }
}
