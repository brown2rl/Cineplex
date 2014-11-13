using System;

namespace Cineplex.Domain.Product
{
    [Serializable]
    public class LightweightProduct
    {
        public LightweightProduct(Product p)
        {
            Id = p.Id;
            ShortName = p.ShortName;
            Description = p.Descriptioin;
            TaxableFlag = p.TaxableFlag;
            RetailPrice = p.RetailPrice;
        }

        public int Id;
        public string ShortName;
        public string Description;
        public bool TaxableFlag;
        public decimal RetailPrice;
    }
}