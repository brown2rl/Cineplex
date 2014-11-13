/*	
	This class was generated using a tool. Manual changes to this class may result
	in a failure to work as designed with the FlyweightObjects.NET engine.
	+-----------------------------------------------------------------------------
	| Generated [11/12/2014 1:12:21 PM], FlyweightObjects.NET Version [3.1.6.9]

*/
using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using FlyweightObjects;

namespace Cineplex.Domain.Customer
{	
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DataTable("[dbo].[Address]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class Address : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(Address));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<CustomerAddress> CustomerAddresses
		{
			get { return this.Storage.GetDataRelation<CustomerAddress>(Properties.NameOf(p => p.CustomerAddresses)).GetProperty(Cineplex.Domain.Customer.CustomerAddress.Properties.AddressId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<CustomerAddress>(Properties.NameOf(p => p.CustomerAddresses)).SetProperty(value); }
		}

		[DataColumn("[Id]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = true, AutoIncrement = true, HasDefault = false)]
		public virtual System.Int32 Id
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.Id)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Id));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.Id), value);
				SendPropertyChanged(Properties.NameOf(p => p.Id));
			}
		}

		[DataColumn("[AddressLine1]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String AddressLine1
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.AddressLine1)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.AddressLine1));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.AddressLine1), value);
				SendPropertyChanged(Properties.NameOf(p => p.AddressLine1));
			}
		}

		[DataColumn("[AddressLine2]", AllowDBNull = true, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String AddressLine2
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.AddressLine2)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.AddressLine2));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.AddressLine2), value);
				SendPropertyChanged(Properties.NameOf(p => p.AddressLine2));
			}
		}

		[DataColumn("[City]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String City
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.City)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.City));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.City), value);
				SendPropertyChanged(Properties.NameOf(p => p.City));
			}
		}

		[DataColumn("[StateCode]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String StateCode
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.StateCode)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.StateCode));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.StateCode), value);
				SendPropertyChanged(Properties.NameOf(p => p.StateCode));
			}
		}

		[DataColumn("[PostalCode]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String PostalCode
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.PostalCode)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.PostalCode));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.PostalCode), value);
				SendPropertyChanged(Properties.NameOf(p => p.PostalCode));
			}
		}

		#region IRedundancyCheck Members
		
		[PropertyStorage]
		public string Checksum
		{
			get { return this.Storage.GetProperty<string>(Properties.NameOf(p => p.Checksum)); }
			set { this.Storage.SetProperty<string>(Properties.NameOf(p => p.Checksum), value); }
		}
		
		#endregion

		#region INotifyPropertyChanging Members
		
		[field: NonSerialized]
		public event PropertyChangingEventHandler PropertyChanging;
		protected void SendPropertyChanging(string propertyName)
		{
			if (string.IsNullOrEmpty(this.Checksum))
			{
				this.Checksum = new ChecksumBuilder().BuildChecksum(this);
			}
			if (this.PropertyChanging != null)
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		#endregion
		
		#region INotifyPropertyChanged Members
		
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;
		protected void SendPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
			if (this is IPropertyChangedTrackable)
			{
				((IPropertyChangedTrackable)this).ChangedProperties.Add(propertyName);
			}
		}
		
		#endregion

		#region IPropertyChangedTrackable Members

		[PropertyStorage]
		public HashSet<string> ChangedProperties
		{
			get { return this.Storage.GetProperty<HashSet<string>>(Properties.NameOf(p => p.ChangedProperties)); }
		}

		#endregion
		
		public static class Properties
		{
			public static string NameOf<T>(Expression<Func<Address, T>> property)
			{
				return PropertyOf<Address>.Name<T>(property);
			}
			
			public static PropertyExpression<Address> Id { get { return new PropertyExpression<Address>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<Address> AddressLine1 { get { return new PropertyExpression<Address>(Properties.NameOf(p => p.AddressLine1)); } }
			public static PropertyExpression<Address> AddressLine2 { get { return new PropertyExpression<Address>(Properties.NameOf(p => p.AddressLine2)); } }
			public static PropertyExpression<Address> City { get { return new PropertyExpression<Address>(Properties.NameOf(p => p.City)); } }
			public static PropertyExpression<Address> StateCode { get { return new PropertyExpression<Address>(Properties.NameOf(p => p.StateCode)); } }
			public static PropertyExpression<Address> PostalCode { get { return new PropertyExpression<Address>(Properties.NameOf(p => p.PostalCode)); } }
		}
	}
}