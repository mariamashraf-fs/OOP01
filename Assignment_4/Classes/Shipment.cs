using Assignment_4.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    public class Shipment
    {
        //private fields
      
        private string trackingCode;
        private string description;
        private decimal weight;
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

        public decimal Weight
        {
            get { return weight; }
            set { weight = (value > 0) ? value : weight;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set { deliveryFee = (value > 0) ? value : deliveryFee;
            }
        }

    
        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        // Con_1
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

        // Con_2
        public Shipment(string tcode, string desc, decimal w, decimal fee, DeliveryAddress destination)

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

        //Assignment_6
        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            Weight = newWeight + packingWeight;
        }

        public  virtual void PrintShipment()
        {
            Console.WriteLine("============= Shipment Details =============");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} KG");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee} EGP");
            Console.WriteLine($"Destination    : {Destination.GetFullAddress()}");
        }
    
    }
}
