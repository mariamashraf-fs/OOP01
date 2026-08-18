using System;
using System.Collections.Generic;
using System.Text;
using Assignment_4.Interfaces;

namespace Assignment_4.Classes
{
    public class DeliveryCenter
    {
        private Shipment?[] shipments;

        public string CenterName { get; set; }


        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment?[20];
        }

        public Driver? AssignedDriver { get; set; }


        // Add Shipment
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }


        // Integer Indexer
        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return null;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }


        // String Indexer
        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    Shipment? shipment = shipments[i];

                    if (shipment != null &&
                        shipment.TrackingCode == trackingCode)
                    {
                        return shipment;
                    }
                }

                return null;
            }
        }


        // Remove Shipment
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                Shipment? shipment = shipments[i];

                if (shipment != null &&
                    shipment.TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }


        // Print All Shipments
        public void PrintAllShipments()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("========================================\n");

            //Assignment_6
            //Console.WriteLine($"Driver : {AssignedDriver?.Name}");

            //Console.WriteLine("---------------------------------------------");

            for (int i = 0; i < shipments.Length; i++)
            {
                Shipment? shipment = shipments[i];

                if (shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine();
                }
            }
        }

        //Assignment_7
        public void PrintTrackingStatuses()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("\nTracking Status");

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                }
            }
        }
    }
}