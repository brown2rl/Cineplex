using System;
using FlyweightObjects;

namespace Cineplex.Common
{
    public static class Constants
    {
        public static class Customer
        {
            public static readonly string CnnString = "Server=(local)\\SQLEXPRESS; Database=brandpop_customer; User Id=sa; Password=P@ssw0rd;";
            public static readonly StorageProviderType ProviderType = StorageProviderType.SqlServer;
            public static readonly bool LoadOnDemand = true;
            public static readonly string DomainName = "Customer";
        }

        public static class Product
        {
            public static readonly string CnnString = "Server=(local)\\SQLEXPRESS; Database=brandpop_product; User Id=sa; Password=P@ssw0rd;";
            public static readonly StorageProviderType ProviderType = StorageProviderType.SqlServer;
            public static readonly bool LoadOnDemand = true;
            public static readonly string DomainName = "Product";
        }
    }
}