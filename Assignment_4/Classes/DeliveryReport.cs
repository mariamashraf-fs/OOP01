using Assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    public class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance : {shipment.CalculateInsurance()} EGP");
        }
    }
}
