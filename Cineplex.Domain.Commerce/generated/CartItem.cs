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
	[DataTable("[dbo].[CartItem]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class CartItem : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(CartItem));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataColumn("[CartId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = true, AutoIncrement = false, HasDefault = false)]
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

		[DataColumn("[ProductId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = true, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 ProductId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.ProductId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ProductId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.ProductId), value);
				SendPropertyChanged(Properties.NameOf(p => p.ProductId));
			}
		}

		[DataColumn("[Quantity]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 Quantity
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.Quantity)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Quantity));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.Quantity), value);
				SendPropertyChanged(Properties.NameOf(p => p.Quantity));
			}
		}

		[DataColumn("[TaxableFlag]", AllowDBNull = false, ColumnType = DbType.Boolean, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.Boolean TaxableFlag
		{
			get { return this.Storage.GetProperty<System.Boolean>(Properties.NameOf(p => p.TaxableFlag)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.TaxableFlag));
				this.Storage.SetProperty<System.Boolean>(Properties.NameOf(p => p.TaxableFlag), value);
				SendPropertyChanged(Properties.NameOf(p => p.TaxableFlag));
			}
		}

		[DataColumn("[CartItemPrice]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal CartItemPrice
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.CartItemPrice)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CartItemPrice));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.CartItemPrice), value);
				SendPropertyChanged(Properties.NameOf(p => p.CartItemPrice));
			}
		}

		[DataColumn("[CartItemTotal]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal CartItemTotal
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.CartItemTotal)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CartItemTotal));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.CartItemTotal), value);
				SendPropertyChanged(Properties.NameOf(p => p.CartItemTotal));
			}
		}

		[DataColumn("[DateAdded]", AllowDBNull = false, ColumnType = DbType.DateTime, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.DateTime DateAdded
		{
			get { return this.Storage.GetProperty<System.DateTime>(Properties.NameOf(p => p.DateAdded)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.DateAdded));
				this.Storage.SetProperty<System.DateTime>(Properties.NameOf(p => p.DateAdded), value);
				SendPropertyChanged(Properties.NameOf(p => p.DateAdded));
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
			public static string NameOf<T>(Expression<Func<CartItem, T>> property)
			{
				return PropertyOf<CartItem>.Name<T>(property);
			}
			
			public static PropertyExpression<CartItem> CartId { get { return new PropertyExpression<CartItem>(Properties.NameOf(p => p.CartId)); } }
			public static PropertyExpression<CartItem> ProductId { get { return new PropertyExpression<CartItem>(Properties.NameOf(p => p.ProductId)); } }
			public static PropertyExpression<CartItem> Quantity { get { return new PropertyExpression<CartItem>(Properties.NameOf(p => p.Quantity)); } }
			public static PropertyExpression<CartItem> TaxableFlag { get { return new PropertyExpression<CartItem>(Properties.NameOf(p => p.TaxableFlag)); } }
			public static PropertyExpression<CartItem> CartItemPrice { get { return new PropertyExpression<CartItem>(Properties.NameOf(p => p.CartItemPrice)); } }
			public static PropertyExpression<CartItem> CartItemTotal { get { return new PropertyExpression<CartItem>(Properties.NameOf(p => p.CartItemTotal)); } }
			public static PropertyExpression<CartItem> DateAdded { get { return new PropertyExpression<CartItem>(Properties.NameOf(p => p.DateAdded)); } }
		}
	}
}