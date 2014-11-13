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
	[DataTable("[dbo].[Order]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class Order : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(Order));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<OrderItem> OrderItems
		{
			get { return this.Storage.GetDataRelation<OrderItem>(Properties.NameOf(p => p.OrderItems)).GetProperty(Cineplex.Domain.Commerce.OrderItem.Properties.OrderId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<OrderItem>(Properties.NameOf(p => p.OrderItems)).SetProperty(value); }
		}

		[DataRelation(AllowPreload=true)]
		public FlyweightSet<OrderPayment> OrderPayments
		{
			get { return this.Storage.GetDataRelation<OrderPayment>(Properties.NameOf(p => p.OrderPayments)).GetProperty(Cineplex.Domain.Commerce.OrderPayment.Properties.OrderId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<OrderPayment>(Properties.NameOf(p => p.OrderPayments)).SetProperty(value); }
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

		[DataColumn("[CartId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 CartId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.CartId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CartId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.CartId), value);
				SendPropertyChanged(Properties.NameOf(p => p.CartId));
			}
		}

		[DataColumn("[CustomerId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 CustomerId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.CustomerId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CustomerId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.CustomerId), value);
				SendPropertyChanged(Properties.NameOf(p => p.CustomerId));
			}
		}

		[DataColumn("[CreateDate]", AllowDBNull = false, ColumnType = DbType.DateTime, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.DateTime CreateDate
		{
			get { return this.Storage.GetProperty<System.DateTime>(Properties.NameOf(p => p.CreateDate)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CreateDate));
				this.Storage.SetProperty<System.DateTime>(Properties.NameOf(p => p.CreateDate), value);
				SendPropertyChanged(Properties.NameOf(p => p.CreateDate));
			}
		}

		[DataColumn("[Subtotal]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal Subtotal
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.Subtotal)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Subtotal));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.Subtotal), value);
				SendPropertyChanged(Properties.NameOf(p => p.Subtotal));
			}
		}

		[DataColumn("[Shipping]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal Shipping
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.Shipping)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Shipping));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.Shipping), value);
				SendPropertyChanged(Properties.NameOf(p => p.Shipping));
			}
		}

		[DataColumn("[SalesTax]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal SalesTax
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.SalesTax)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.SalesTax));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.SalesTax), value);
				SendPropertyChanged(Properties.NameOf(p => p.SalesTax));
			}
		}

		[DataColumn("[Total]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal Total
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.Total)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Total));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.Total), value);
				SendPropertyChanged(Properties.NameOf(p => p.Total));
			}
		}

		[DataColumn("[FundedFlag]", AllowDBNull = false, ColumnType = DbType.Boolean, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.Boolean FundedFlag
		{
			get { return this.Storage.GetProperty<System.Boolean>(Properties.NameOf(p => p.FundedFlag)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.FundedFlag));
				this.Storage.SetProperty<System.Boolean>(Properties.NameOf(p => p.FundedFlag), value);
				SendPropertyChanged(Properties.NameOf(p => p.FundedFlag));
			}
		}

		[DataColumn("[FulfilledFlag]", AllowDBNull = false, ColumnType = DbType.Boolean, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.Boolean FulfilledFlag
		{
			get { return this.Storage.GetProperty<System.Boolean>(Properties.NameOf(p => p.FulfilledFlag)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.FulfilledFlag));
				this.Storage.SetProperty<System.Boolean>(Properties.NameOf(p => p.FulfilledFlag), value);
				SendPropertyChanged(Properties.NameOf(p => p.FulfilledFlag));
			}
		}

		[DataColumn("[ShippedFlag]", AllowDBNull = false, ColumnType = DbType.Boolean, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.Boolean ShippedFlag
		{
			get { return this.Storage.GetProperty<System.Boolean>(Properties.NameOf(p => p.ShippedFlag)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ShippedFlag));
				this.Storage.SetProperty<System.Boolean>(Properties.NameOf(p => p.ShippedFlag), value);
				SendPropertyChanged(Properties.NameOf(p => p.ShippedFlag));
			}
		}

		[DataColumn("[BillToAddressId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 BillToAddressId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.BillToAddressId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.BillToAddressId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.BillToAddressId), value);
				SendPropertyChanged(Properties.NameOf(p => p.BillToAddressId));
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
			public static string NameOf<T>(Expression<Func<Order, T>> property)
			{
				return PropertyOf<Order>.Name<T>(property);
			}
			
			public static PropertyExpression<Order> Id { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<Order> CartId { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.CartId)); } }
			public static PropertyExpression<Order> CustomerId { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.CustomerId)); } }
			public static PropertyExpression<Order> CreateDate { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.CreateDate)); } }
			public static PropertyExpression<Order> Subtotal { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.Subtotal)); } }
			public static PropertyExpression<Order> Shipping { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.Shipping)); } }
			public static PropertyExpression<Order> SalesTax { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.SalesTax)); } }
			public static PropertyExpression<Order> Total { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.Total)); } }
			public static PropertyExpression<Order> FundedFlag { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.FundedFlag)); } }
			public static PropertyExpression<Order> FulfilledFlag { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.FulfilledFlag)); } }
			public static PropertyExpression<Order> ShippedFlag { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.ShippedFlag)); } }
			public static PropertyExpression<Order> BillToAddressId { get { return new PropertyExpression<Order>(Properties.NameOf(p => p.BillToAddressId)); } }
		}
	}
}