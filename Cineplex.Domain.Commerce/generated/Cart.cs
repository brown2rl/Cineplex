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
	[DataTable("[dbo].[Cart]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class Cart : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(Cart));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<CartItem> CartItems
		{
			get { return this.Storage.GetDataRelation<CartItem>(Properties.NameOf(p => p.CartItems)).GetProperty(Cineplex.Domain.Commerce.CartItem.Properties.CartId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<CartItem>(Properties.NameOf(p => p.CartItems)).SetProperty(value); }
		}

		[DataRelation(AllowPreload=true)]
		public FlyweightSet<Order> Orders
		{
			get { return this.Storage.GetDataRelation<Order>(Properties.NameOf(p => p.Orders)).GetProperty(Cineplex.Domain.Commerce.Order.Properties.CartId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<Order>(Properties.NameOf(p => p.Orders)).SetProperty(value); }
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

		[DataColumn("[OrderFlag]", AllowDBNull = false, ColumnType = DbType.Boolean, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.Boolean OrderFlag
		{
			get { return this.Storage.GetProperty<System.Boolean>(Properties.NameOf(p => p.OrderFlag)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.OrderFlag));
				this.Storage.SetProperty<System.Boolean>(Properties.NameOf(p => p.OrderFlag), value);
				SendPropertyChanged(Properties.NameOf(p => p.OrderFlag));
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
			public static string NameOf<T>(Expression<Func<Cart, T>> property)
			{
				return PropertyOf<Cart>.Name<T>(property);
			}
			
			public static PropertyExpression<Cart> Id { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<Cart> CustomerId { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.CustomerId)); } }
			public static PropertyExpression<Cart> CreateDate { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.CreateDate)); } }
			public static PropertyExpression<Cart> Subtotal { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.Subtotal)); } }
			public static PropertyExpression<Cart> Shipping { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.Shipping)); } }
			public static PropertyExpression<Cart> SalesTax { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.SalesTax)); } }
			public static PropertyExpression<Cart> Total { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.Total)); } }
			public static PropertyExpression<Cart> OrderFlag { get { return new PropertyExpression<Cart>(Properties.NameOf(p => p.OrderFlag)); } }
		}
	}
}