/*	
	This class was generated using a tool. Manual changes to this class may result
	in a failure to work as designed with the FlyweightObjects.NET engine.
	+-----------------------------------------------------------------------------
	| Generated [11/12/2014 3:35:42 PM], FlyweightObjects.NET Version [3.1.6.9]

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
	[DataTable("[dbo].[CustomerAccount]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class CustomerAccount : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(CustomerAccount));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
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

		[DataColumn("[FirstName]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String FirstName
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.FirstName)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.FirstName));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.FirstName), value);
				SendPropertyChanged(Properties.NameOf(p => p.FirstName));
			}
		}

		[DataColumn("[LastName]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String LastName
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.LastName)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.LastName));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.LastName), value);
				SendPropertyChanged(Properties.NameOf(p => p.LastName));
			}
		}

		[DataColumn("[CompanyName]", AllowDBNull = true, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String CompanyName
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.CompanyName)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CompanyName));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.CompanyName), value);
				SendPropertyChanged(Properties.NameOf(p => p.CompanyName));
			}
		}

		[DataColumn("[DefaultEmailAddress]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String DefaultEmailAddress
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.DefaultEmailAddress)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.DefaultEmailAddress));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.DefaultEmailAddress), value);
				SendPropertyChanged(Properties.NameOf(p => p.DefaultEmailAddress));
			}
		}

		[DataColumn("[CustomerSegmentId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 CustomerSegmentId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.CustomerSegmentId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CustomerSegmentId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.CustomerSegmentId), value);
				SendPropertyChanged(Properties.NameOf(p => p.CustomerSegmentId));
			}
		}

		[DataColumn("[DefaultShipMethodId]", AllowDBNull = true, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual Nullable<System.Int32> DefaultShipMethodId
		{
			get { return this.Storage.GetProperty<Nullable<System.Int32>>(Properties.NameOf(p => p.DefaultShipMethodId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.DefaultShipMethodId));
				this.Storage.SetProperty<Nullable<System.Int32>>(Properties.NameOf(p => p.DefaultShipMethodId), value);
				SendPropertyChanged(Properties.NameOf(p => p.DefaultShipMethodId));
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
			public static string NameOf<T>(Expression<Func<CustomerAccount, T>> property)
			{
				return PropertyOf<CustomerAccount>.Name<T>(property);
			}
			
			public static PropertyExpression<CustomerAccount> Id { get { return new PropertyExpression<CustomerAccount>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<CustomerAccount> FirstName { get { return new PropertyExpression<CustomerAccount>(Properties.NameOf(p => p.FirstName)); } }
			public static PropertyExpression<CustomerAccount> LastName { get { return new PropertyExpression<CustomerAccount>(Properties.NameOf(p => p.LastName)); } }
			public static PropertyExpression<CustomerAccount> CompanyName { get { return new PropertyExpression<CustomerAccount>(Properties.NameOf(p => p.CompanyName)); } }
			public static PropertyExpression<CustomerAccount> DefaultEmailAddress { get { return new PropertyExpression<CustomerAccount>(Properties.NameOf(p => p.DefaultEmailAddress)); } }
			public static PropertyExpression<CustomerAccount> CustomerSegmentId { get { return new PropertyExpression<CustomerAccount>(Properties.NameOf(p => p.CustomerSegmentId)); } }
			public static PropertyExpression<CustomerAccount> DefaultShipMethodId { get { return new PropertyExpression<CustomerAccount>(Properties.NameOf(p => p.DefaultShipMethodId)); } }
		}
	}
}