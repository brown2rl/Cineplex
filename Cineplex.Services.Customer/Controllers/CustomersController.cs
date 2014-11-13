using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Cineplex.Domain.Customer;
using FlyweightObjects;

namespace Cineplex.Services.Customer.Controllers
{
    public class CustomersController : ApiController
    {
        private static DataContext GetDataContext()
        {
            return new DataContext(
                Common.Constants.Customer.CnnString,
                Common.Constants.Customer.ProviderType,
                Common.Constants.Customer.LoadOnDemand,
                Common.Constants.Customer.DomainName
            );
        }

        public IEnumerable<LightweightCustomer> Get()
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<CustomerAccount>()
                    .Select()
                    .From<CustomerAccount>();

                return dc.Select(query).Select(c => new LightweightCustomer(c)).ToList();
            }
        }

        public IEnumerable<LightweightCustomer> Get(string searchCriteria)
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<CustomerAccount>()
                    .Select()
                    .From<CustomerAccount>()
                    .Where(CustomerAccount.Properties.FirstName.Contains(searchCriteria))
                    .Or(CustomerAccount.Properties.LastName.Contains(searchCriteria))
                    .Or(CustomerAccount.Properties.CompanyName.Contains(searchCriteria));

                return dc.Select(query).Select(c => new LightweightCustomer(c)).ToList();
            }
        }

        public LightweightCustomer Get(int id)
        {
            using (var dc = GetDataContext())
            {
                var query = new QueryExpression<CustomerAccount>()
                    .Select()
                    .From<CustomerAccount>()
                    .Where(CustomerAccount.Properties.Id == id);

                var customer = dc.Select(query).ToSingle();

                return customer != null ? new LightweightCustomer(customer) : null;
            }
        }
    }
}