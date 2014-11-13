using System;

namespace Cineplex.Domain.Customer
{
    [Serializable]
    public class LightweightCustomer
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string CompanyName;
        public string DefaultEmailAddress;
        public int CustomerSegmentId;
        public int? DefaultShipMethodId;

        public LightweightCustomer(CustomerAccount c)
        {
            Id                  = c.Id;
            FirstName           = c.FirstName;
            LastName            = c.LastName;
            CompanyName         = c.CompanyName;
            DefaultEmailAddress = c.DefaultEmailAddress;
            CustomerSegmentId   = c.CustomerSegmentId;
            DefaultShipMethodId = c.DefaultShipMethodId;
        }
    }
}