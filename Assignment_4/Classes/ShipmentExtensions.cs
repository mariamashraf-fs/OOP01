using Assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string type = shipment.GetType().Name.Replace("Shipment", "");
            string status = GetShortStatus(shipment);

            return $"{shipment.TrackingCode} | {type} | {shipment.Weight} KG | {status}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment is ITrackable trackable)
            {
                return trackable.GetTrackingStatus().Contains("Delivered");
            }
            return false;
        }

        private static string GetShortStatus(Shipment shipment)
        {
            if (shipment is StandardShipment) return "In Transit";
            if (shipment is ExpressShipment) return "Out For Delivery";
            if (shipment is InternationalShipment) return "Delivered";
            return "Unknown";
        }
    }


}
