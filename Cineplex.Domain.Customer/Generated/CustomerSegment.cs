/*	
	This class was generated using a tool. Manual changes to this class may result
	in a failure to work as designed with the FlyweightObjects.NET engine.
	+-----------------------------------------------------------------------------
	| Generated [11/12/2014 3:35:42 PM], FlyweightObjects.NET Version [3.1.6.9]

*/
using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using FlyweightObjects;

namespace Cineplex.Domain.Customer
{	
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DataTable("[dbo].[CustomerSegment]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class CustomerSegment : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(CustomerSegment));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<CustomerAccount> Customers
		{
			get { return this.Storage.GetDataRelation<CustomerAccount>(Properties.NameOf(p => p.Customers)).GetProperty(Cineplex.Domain.Customer.CustomerAccount.Properties.CustomerSegmentId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<CustomerAccount>(Properties.NameOf(p => p.Customers)).SetProperty(value); }
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

		[DataColumn("[SegmentName]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String SegmentName
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.SegmentName)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.SegmentName));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.SegmentName), value);
				SendPropertyChanged(Properties.NameOf(p => p.SegmentName));
			}
		}

		[DataColumn("[Description]", AllowDBNull = true, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String Description
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.Description)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Description));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.Description), value);
				SendPropertyChanged(Properties.NameOf(p => p.Description));
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
			public static string NameOf<T>(Expression<Func<CustomerSegment, T>> property)
			{
				return PropertyOf<CustomerSegment>.Name<T>(property);
			}
			
			public static PropertyExpression<CustomerSegment> Id { get { return new PropertyExpression<CustomerSegment>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<CustomerSegment> SegmentName { get { return new PropertyExpression<CustomerSegment>(Properties.NameOf(p => p.SegmentName)); } }
			public static PropertyExpression<CustomerSegment> Description { get { return new PropertyExpression<CustomerSegment>(Properties.NameOf(p => p.Description)); } }
		}
	}
}