using System;
using System.Collections.Generic;
using System.Web.Http;
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

        public IEnumerable<Domain.Product.Product> Get()
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<Domain.Product.Product>()
                    .Select()
                    .From<Domain.Product.Product>();

                return dc.Select(query);
            }
        }

        public IEnumerable<Domain.Product.Product> Get(string searchCriteria)
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<Domain.Product.Product>()
                    .Select()
                    .From<Domain.Product.Product>()
                    .Where(Domain.Product.Product.Properties.ShortName.Contains(searchCriteria))
                    .Or(Domain.Product.Product.Properties.Descriptioin.Contains(searchCriteria));

                return dc.Select(query);
            }
        }

        public Domain.Product.Product Get(int id)
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<Domain.Product.Product>()
                    .Select()
                    .From<Domain.Product.Product>()
                    .Where(Domain.Product.Product.Properties.Id == id);
                
                var product = dc.Select(query).ToSingle();
                return product ?? null;
            }
        }
    }
}