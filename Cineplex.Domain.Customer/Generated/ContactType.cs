/*	
	This class was generated using a tool. Manual changes to this class may result
	in a failure to work as designed with the FlyweightObjects.NET engine.
	+-----------------------------------------------------------------------------
	| Generated [11/12/2014 1:12:21 PM], FlyweightObjects.NET Version [3.1.6.9]

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
	[DataTable("[dbo].[ContactType]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class ContactType : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(ContactType));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<CustomerAddress> CustomerAddresses
		{
			get { return this.Storage.GetDataRelation<CustomerAddress>(Properties.NameOf(p => p.CustomerAddresses)).GetProperty(Cineplex.Domain.Customer.CustomerAddress.Properties.ContactTypeId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<CustomerAddress>(Properties.NameOf(p => p.CustomerAddresses)).SetProperty(value); }
		}

		[DataRelation(AllowPreload=true)]
		public FlyweightSet<CustomerTelephone> CustomerTelephones
		{
			get { return this.Storage.GetDataRelation<CustomerTelephone>(Properties.NameOf(p => p.CustomerTelephones)).GetProperty(Cineplex.Domain.Customer.CustomerTelephone.Properties.ContactTypeId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<CustomerTelephone>(Properties.NameOf(p => p.CustomerTelephones)).SetProperty(value); }
		}

		[DataRelation(AllowPreload=true)]
		public FlyweightSet<EmailAddress> EmailAddresses
		{
			get { return this.Storage.GetDataRelation<EmailAddress>(Properties.NameOf(p => p.EmailAddresses)).GetProperty(Cineplex.Domain.Customer.EmailAddress.Properties.ContactTypeId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<EmailAddress>(Properties.NameOf(p => p.EmailAddresses)).SetProperty(value); }
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

		[DataColumn("[TypeName]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String TypeName
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.TypeName)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.TypeName));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.TypeName), value);
				SendPropertyChanged(Properties.NameOf(p => p.TypeName));
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
			public static string NameOf<T>(Expression<Func<ContactType, T>> property)
			{
				return PropertyOf<ContactType>.Name<T>(property);
			}
			
			public static PropertyExpression<ContactType> Id { get { return new PropertyExpression<ContactType>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<ContactType> TypeName { get { return new PropertyExpression<ContactType>(Properties.NameOf(p => p.TypeName)); } }
		}
	}
}