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
	[DataTable("[dbo].[ShipMethod]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class ShipMethod : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(ShipMethod));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<Shipment> Shipments
		{
			get { return this.Storage.GetDataRelation<Shipment>(Properties.NameOf(p => p.Shipments)).GetProperty(Cineplex.Domain.Fulfillment.Shipment.Properties.ShipMethodId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<Shipment>(Properties.NameOf(p => p.Shipments)).SetProperty(value); }
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

		[DataColumn("[MethodName]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String MethodName
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.MethodName)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.MethodName));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.MethodName), value);
				SendPropertyChanged(Properties.NameOf(p => p.MethodName));
			}
		}

		[DataColumn("[TrackingUrl]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String TrackingUrl
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.TrackingUrl)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.TrackingUrl));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.TrackingUrl), value);
				SendPropertyChanged(Properties.NameOf(p => p.TrackingUrl));
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
			public static string NameOf<T>(Expression<Func<ShipMethod, T>> property)
			{
				return PropertyOf<ShipMethod>.Name<T>(property);
			}
			
			public static PropertyExpression<ShipMethod> Id { get { return new PropertyExpression<ShipMethod>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<ShipMethod> MethodName { get { return new PropertyExpression<ShipMethod>(Properties.NameOf(p => p.MethodName)); } }
			public static PropertyExpression<ShipMethod> TrackingUrl { get { return new PropertyExpression<ShipMethod>(Properties.NameOf(p => p.TrackingUrl)); } }
		}
	}
}