/*	
	This class was generated using a tool. Manual changes to this class may result
	in a failure to work as designed with the FlyweightObjects.NET engine.
	+-----------------------------------------------------------------------------
	| Generated [11/12/2014 1:34:34 PM], FlyweightObjects.NET Version [3.1.6.9]

*/
using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using FlyweightObjects;

namespace Cineplex.Domain.Product
{	
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DataTable("[dbo].[Product]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class Product : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(Product));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<ProductSegment> ProductSegments
		{
			get { return this.Storage.GetDataRelation<ProductSegment>(Properties.NameOf(p => p.ProductSegments)).GetProperty(Cineplex.Domain.Product.ProductSegment.Properties.ProductId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<ProductSegment>(Properties.NameOf(p => p.ProductSegments)).SetProperty(value); }
		}

		[DataRelation(AllowPreload=true)]
		public FlyweightSet<SupplierProduct> SupplierProducts
		{
			get { return this.Storage.GetDataRelation<SupplierProduct>(Properties.NameOf(p => p.SupplierProducts)).GetProperty(Cineplex.Domain.Product.SupplierProduct.Properties.ProductId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<SupplierProduct>(Properties.NameOf(p => p.SupplierProducts)).SetProperty(value); }
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

		[DataColumn("[ShortName]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String ShortName
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.ShortName)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ShortName));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.ShortName), value);
				SendPropertyChanged(Properties.NameOf(p => p.ShortName));
			}
		}

		[DataColumn("[Descriptioin]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String Descriptioin
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.Descriptioin)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Descriptioin));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.Descriptioin), value);
				SendPropertyChanged(Properties.NameOf(p => p.Descriptioin));
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

		[DataColumn("[RetailPrice]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = true)]
		public virtual System.Decimal RetailPrice
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.RetailPrice)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.RetailPrice));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.RetailPrice), value);
				SendPropertyChanged(Properties.NameOf(p => p.RetailPrice));
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
			public static string NameOf<T>(Expression<Func<Product, T>> property)
			{
				return PropertyOf<Product>.Name<T>(property);
			}
			
			public static PropertyExpression<Product> Id { get { return new PropertyExpression<Product>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<Product> ShortName { get { return new PropertyExpression<Product>(Properties.NameOf(p => p.ShortName)); } }
			public static PropertyExpression<Product> Descriptioin { get { return new PropertyExpression<Product>(Properties.NameOf(p => p.Descriptioin)); } }
			public static PropertyExpression<Product> TaxableFlag { get { return new PropertyExpression<Product>(Properties.NameOf(p => p.TaxableFlag)); } }
			public static PropertyExpression<Product> RetailPrice { get { return new PropertyExpression<Product>(Properties.NameOf(p => p.RetailPrice)); } }
		}
	}
}