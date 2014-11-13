/*	
	This class was generated using a tool. Manual changes to this class may result
	in a failure to work as designed with the FlyweightObjects.NET engine.
	+-----------------------------------------------------------------------------
	| Generated [11/12/2014 1:33:22 PM], FlyweightObjects.NET Version [3.1.6.9]

*/
using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using FlyweightObjects;

namespace Cineplex.Domain.Fulfillment
{	
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DataTable("[dbo].[Shipment]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class Shipment : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(Shipment));
		
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

		[DataColumn("[OrderId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 OrderId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.OrderId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.OrderId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.OrderId), value);
				SendPropertyChanged(Properties.NameOf(p => p.OrderId));
			}
		}

		[DataColumn("[ShipToAddressId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 ShipToAddressId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.ShipToAddressId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ShipToAddressId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.ShipToAddressId), value);
				SendPropertyChanged(Properties.NameOf(p => p.ShipToAddressId));
			}
		}

		[DataColumn("[ShipMethodId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 ShipMethodId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.ShipMethodId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ShipMethodId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.ShipMethodId), value);
				SendPropertyChanged(Properties.NameOf(p => p.ShipMethodId));
			}
		}

		[DataColumn("[TrackingNumber]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String TrackingNumber
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.TrackingNumber)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.TrackingNumber));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.TrackingNumber), value);
				SendPropertyChanged(Properties.NameOf(p => p.TrackingNumber));
			}
		}

		[DataColumn("[ShipWeight]", AllowDBNull = false, ColumnType = DbType.Decimal, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal ShipWeight
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.ShipWeight)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ShipWeight));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.ShipWeight), value);
				SendPropertyChanged(Properties.NameOf(p => p.ShipWeight));
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
			public static string NameOf<T>(Expression<Func<Shipment, T>> property)
			{
				return PropertyOf<Shipment>.Name<T>(property);
			}
			
			public static PropertyExpression<Shipment> Id { get { return new PropertyExpression<Shipment>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<Shipment> OrderId { get { return new PropertyExpression<Shipment>(Properties.NameOf(p => p.OrderId)); } }
			public static PropertyExpression<Shipment> ShipToAddressId { get { return new PropertyExpression<Shipment>(Properties.NameOf(p => p.ShipToAddressId)); } }
			public static PropertyExpression<Shipment> ShipMethodId { get { return new PropertyExpression<Shipment>(Properties.NameOf(p => p.ShipMethodId)); } }
			public static PropertyExpression<Shipment> TrackingNumber { get { return new PropertyExpression<Shipment>(Properties.NameOf(p => p.TrackingNumber)); } }
			public static PropertyExpression<Shipment> ShipWeight { get { return new PropertyExpression<Shipment>(Properties.NameOf(p => p.ShipWeight)); } }
		}
	}
}