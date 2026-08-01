using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Structs
{
    public struct Shipment
    {
        //private fields

        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        // properties
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
            private set { if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            set { if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = (value > 0) ? value : weight; }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set { deliveryFee = (value > 0) ? value : deliveryFee; }

        }

        public decimal EstimatedCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5); }
        }

        //Con_1
        public Shipment(string tcode)
        {
            trackingCode = "";
            description = "";
            weight = 0;
            deliveryFee = 0;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

            TrackingCode = tcode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
        }

        //Con_2
        public Shipment(string tcode, string desc, double w, decimal fee, DeliveryAddress destination)
        {
            trackingCode = "";
            description = "";
            weight = 0;
            deliveryFee = 0;
            Destination = destination;

            TrackingCode = tcode;
            Description = desc;
            Weight = w;
            DeliveryFee = fee;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = (newFee > 0) ? newFee : DeliveryFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine("============= Shipment Details =============");
            Console.WriteLine($"Tracking Code -> {TrackingCode}");
            Console.WriteLine($"Description -> {Description}");
            Console.WriteLine($"Weight -> {Weight}");
            Console.WriteLine($"Delivery Fee -> {DeliveryFee}");
            Console.WriteLine($"Destination -> {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost -> {EstimatedCost}");
        }

    }
}
