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
	[DataTable("[dbo].[SupplierProduct]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class SupplierProduct : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(SupplierProduct));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataColumn("[SupplierId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = true, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 SupplierId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.SupplierId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.SupplierId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.SupplierId), value);
				SendPropertyChanged(Properties.NameOf(p => p.SupplierId));
			}
		}

		[DataColumn("[SupplierProductCode]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = true, AutoIncrement = false, HasDefault = false)]
		public virtual System.String SupplierProductCode
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.SupplierProductCode)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.SupplierProductCode));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.SupplierProductCode), value);
				SendPropertyChanged(Properties.NameOf(p => p.SupplierProductCode));
			}
		}

		[DataColumn("[ProductId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
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

		[DataColumn("[SupplierDescription]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String SupplierDescription
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.SupplierDescription)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.SupplierDescription));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.SupplierDescription), value);
				SendPropertyChanged(Properties.NameOf(p => p.SupplierDescription));
			}
		}

		[DataColumn("[SupplierCost]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal SupplierCost
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.SupplierCost)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.SupplierCost));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.SupplierCost), value);
				SendPropertyChanged(Properties.NameOf(p => p.SupplierCost));
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
			public static string NameOf<T>(Expression<Func<SupplierProduct, T>> property)
			{
				return PropertyOf<SupplierProduct>.Name<T>(property);
			}
			
			public static PropertyExpression<SupplierProduct> SupplierId { get { return new PropertyExpression<SupplierProduct>(Properties.NameOf(p => p.SupplierId)); } }
			public static PropertyExpression<SupplierProduct> SupplierProductCode { get { return new PropertyExpression<SupplierProduct>(Properties.NameOf(p => p.SupplierProductCode)); } }
			public static PropertyExpression<SupplierProduct> ProductId { get { return new PropertyExpression<SupplierProduct>(Properties.NameOf(p => p.ProductId)); } }
			public static PropertyExpression<SupplierProduct> SupplierDescription { get { return new PropertyExpression<SupplierProduct>(Properties.NameOf(p => p.SupplierDescription)); } }
			public static PropertyExpression<SupplierProduct> SupplierCost { get { return new PropertyExpression<SupplierProduct>(Properties.NameOf(p => p.SupplierCost)); } }
		}
	}
}