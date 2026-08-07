using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Structs
{
    
        public struct DeliveryCenter
        {
            private Shipment[] shipments;

            public DeliveryCenter()
            {
                shipments = new Shipment[10];
            }

            // Integer Indexer
            public Shipment this[int index]
            {
                get { if (index >= 0 && index < shipments.Length)
                        return shipments[index];
                    else
                        return default;
                }

                set { if (index >= 0 && index < shipments.Length)
                        shipments[index] = value;
                }
            }

            // String Indexer
            public Shipment this[string trackingCode]
            {
                get { for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i].TrackingCode == trackingCode)
                            return shipments[i];
                    }

                    return default;
                }
            }

            // Add Shipment
            public bool AddShipment(Shipment shipment)
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(shipments[i].TrackingCode))
                    {
                        shipments[i] = shipment;
                        return true;
                    }
                }

                return false;
            }
        }
    
}
