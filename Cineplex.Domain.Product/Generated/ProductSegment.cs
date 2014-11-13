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
	[DataTable("[dbo].[ProductSegment]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class ProductSegment : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(ProductSegment));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
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

		[DataColumn("[CustomerSegmentId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = true, AutoIncrement = false, HasDefault = false)]
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

		[DataColumn("[CustomerSegmentPriceOverride]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal CustomerSegmentPriceOverride
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.CustomerSegmentPriceOverride)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CustomerSegmentPriceOverride));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.CustomerSegmentPriceOverride), value);
				SendPropertyChanged(Properties.NameOf(p => p.CustomerSegmentPriceOverride));
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
			public static string NameOf<T>(Expression<Func<ProductSegment, T>> property)
			{
				return PropertyOf<ProductSegment>.Name<T>(property);
			}
			
			public static PropertyExpression<ProductSegment> ProductId { get { return new PropertyExpression<ProductSegment>(Properties.NameOf(p => p.ProductId)); } }
			public static PropertyExpression<ProductSegment> CustomerSegmentId { get { return new PropertyExpression<ProductSegment>(Properties.NameOf(p => p.CustomerSegmentId)); } }
			public static PropertyExpression<ProductSegment> CustomerSegmentPriceOverride { get { return new PropertyExpression<ProductSegment>(Properties.NameOf(p => p.CustomerSegmentPriceOverride)); } }
		}
	}
}