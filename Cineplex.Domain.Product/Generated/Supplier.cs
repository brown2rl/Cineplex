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
	[DataTable("[dbo].[Supplier]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class Supplier : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(Supplier));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<SupplierProduct> SupplierProducts
		{
			get { return this.Storage.GetDataRelation<SupplierProduct>(Properties.NameOf(p => p.SupplierProducts)).GetProperty(Cineplex.Domain.Product.SupplierProduct.Properties.SupplierId == this.Id).ToFlyweightSet(); }
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
			public static string NameOf<T>(Expression<Func<Supplier, T>> property)
			{
				return PropertyOf<Supplier>.Name<T>(property);
			}
			
			public static PropertyExpression<Supplier> Id { get { return new PropertyExpression<Supplier>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<Supplier> CustomerId { get { return new PropertyExpression<Supplier>(Properties.NameOf(p => p.CustomerId)); } }
		}
	}
}