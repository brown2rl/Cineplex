using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Cineplex.Domain.Product;
using FlyweightObjects;

namespace Cineplex.Services.Product.Controllers
{
    public class ProductsController : ApiController
    {
        private static DataContext GetDataContext()
        {
            return new DataContext(
                Common.Constants.Product.CnnString,
                Common.Constants.Product.ProviderType,
                Common.Constants.Product.LoadOnDemand,
                Common.Constants.Product.DomainName
            );
        }

        public IEnumerable<LightweightProduct> Get()
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<Domain.Product.Product>()
                    .Select()
                    .From<Domain.Product.Product>();

                return dc.Select(query).Select(p => new LightweightProduct(p)).ToList();
            }
        }

        public IEnumerable<LightweightProduct> Get(string searchCriteria)
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<Domain.Product.Product>()
                    .Select()
                    .From<Domain.Product.Product>()
                    .Where(Domain.Product.Product.Properties.ShortName.Contains(searchCriteria))
                    .Or(Domain.Product.Product.Properties.Descriptioin.Contains(searchCriteria));

                return dc.Select(query).Select(c => new LightweightProduct(c)).ToList();
            }
        }

        public LightweightProduct Get(int id)
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<Domain.Product.Product>()
                    .Select()
                    .From<Domain.Product.Product>()
                    .Where(Domain.Product.Product.Properties.Id == id);
                
                var product = dc.Select(query).ToSingle();
                
                return product != null ? new LightweightProduct(product) : null;
            }
        }
    }
}