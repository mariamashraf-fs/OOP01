using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Structs
{
    public /*struct*/ class DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string c, string st, int bnum)
        {
            City = c;
            Street = st;
            BuildingNumber = bnum;
        }

        public string GetFullAddress()
        {
            return $"{BuildingNumber}, {Street}, {City}";
        }
    }
}
