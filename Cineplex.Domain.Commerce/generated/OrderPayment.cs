/*	
	This class was generated using a tool. Manual changes to this class may result
	in a failure to work as designed with the FlyweightObjects.NET engine.
	+-----------------------------------------------------------------------------
	| Generated [11/12/2014 11:26:43 AM], FlyweightObjects.NET Version [3.1.6.9]

*/
using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using FlyweightObjects;

namespace Cineplex.Domain.Commerce
{	
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DataTable("[dbo].[OrderPayment]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class OrderPayment : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(OrderPayment));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataColumn("[OrderId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = true, AutoIncrement = false, HasDefault = false)]
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

		[DataColumn("[PaymentId]", AllowDBNull = false, ColumnType = DbType.Guid, Identifier = true, AutoIncrement = false, HasDefault = false)]
		public virtual System.Guid PaymentId
		{
			get { return this.Storage.GetProperty<System.Guid>(Properties.NameOf(p => p.PaymentId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.PaymentId));
				this.Storage.SetProperty<System.Guid>(Properties.NameOf(p => p.PaymentId), value);
				SendPropertyChanged(Properties.NameOf(p => p.PaymentId));
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
			public static string NameOf<T>(Expression<Func<OrderPayment, T>> property)
			{
				return PropertyOf<OrderPayment>.Name<T>(property);
			}
			
			public static PropertyExpression<OrderPayment> OrderId { get { return new PropertyExpression<OrderPayment>(Properties.NameOf(p => p.OrderId)); } }
			public static PropertyExpression<OrderPayment> PaymentId { get { return new PropertyExpression<OrderPayment>(Properties.NameOf(p => p.PaymentId)); } }
		}
	}
}