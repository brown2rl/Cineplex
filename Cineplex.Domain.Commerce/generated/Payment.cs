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
	[DataTable("[dbo].[Payment]", AllowSelect = true, AllowInsert = true, AllowUpdate = true, AllowDelete = true, AllowTruncate = true, EnableCaching = false, CacheTimeout = 0)]
	public partial class Payment : IFlyweight, IRedundancyCheck, INotifyPropertyChanging, INotifyPropertyChanged, IPropertyChangedTrackable
	{
		PropertyStorage Storage = new PropertyStorage(typeof(Payment));
		
		PropertyStorage IFlyweight.Storage
		{
			get { return this.Storage; }
			set { this.Storage = value; }
		}
		
		[DataRelation(AllowPreload=true)]
		public FlyweightSet<OrderPayment> OrderPayments
		{
			get { return this.Storage.GetDataRelation<OrderPayment>(Properties.NameOf(p => p.OrderPayments)).GetProperty(Cineplex.Domain.Commerce.OrderPayment.Properties.PaymentId == this.Id).ToFlyweightSet(); }
			set { this.Storage.GetDataRelation<OrderPayment>(Properties.NameOf(p => p.OrderPayments)).SetProperty(value); }
		}

		[DataColumn("[Id]", AllowDBNull = false, ColumnType = DbType.Guid, Identifier = true, AutoIncrement = false, HasDefault = true)]
		public virtual System.Guid Id
		{
			get { return this.Storage.GetProperty<System.Guid>(Properties.NameOf(p => p.Id)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Id));
				this.Storage.SetProperty<System.Guid>(Properties.NameOf(p => p.Id), value);
				SendPropertyChanged(Properties.NameOf(p => p.Id));
			}
		}

		[DataColumn("[PaymentTypeId]", AllowDBNull = false, ColumnType = DbType.Int32, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Int32 PaymentTypeId
		{
			get { return this.Storage.GetProperty<System.Int32>(Properties.NameOf(p => p.PaymentTypeId)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.PaymentTypeId));
				this.Storage.SetProperty<System.Int32>(Properties.NameOf(p => p.PaymentTypeId), value);
				SendPropertyChanged(Properties.NameOf(p => p.PaymentTypeId));
			}
		}

		[DataColumn("[CCNumber]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String CCNumber
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.CCNumber)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.CCNumber));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.CCNumber), value);
				SendPropertyChanged(Properties.NameOf(p => p.CCNumber));
			}
		}

		[DataColumn("[CCID]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String Ccid
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.Ccid)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.Ccid));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.Ccid), value);
				SendPropertyChanged(Properties.NameOf(p => p.Ccid));
			}
		}

		[DataColumn("[ExpirationMonth]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String ExpirationMonth
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.ExpirationMonth)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ExpirationMonth));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.ExpirationMonth), value);
				SendPropertyChanged(Properties.NameOf(p => p.ExpirationMonth));
			}
		}

		[DataColumn("[ExpirationYear]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String ExpirationYear
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.ExpirationYear)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.ExpirationYear));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.ExpirationYear), value);
				SendPropertyChanged(Properties.NameOf(p => p.ExpirationYear));
			}
		}

		[DataColumn("[AuthorizationCode]", AllowDBNull = false, ColumnType = DbType.AnsiStringFixedLength, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.String AuthorizationCode
		{
			get { return this.Storage.GetProperty<System.String>(Properties.NameOf(p => p.AuthorizationCode)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.AuthorizationCode));
				this.Storage.SetProperty<System.String>(Properties.NameOf(p => p.AuthorizationCode), value);
				SendPropertyChanged(Properties.NameOf(p => p.AuthorizationCode));
			}
		}

		[DataColumn("[PaymentAmount]", AllowDBNull = false, ColumnType = DbType.Currency, Identifier = false, AutoIncrement = false, HasDefault = false)]
		public virtual System.Decimal PaymentAmount
		{
			get { return this.Storage.GetProperty<System.Decimal>(Properties.NameOf(p => p.PaymentAmount)); }
			set 
			{ 
				SendPropertyChanging(Properties.NameOf(p => p.PaymentAmount));
				this.Storage.SetProperty<System.Decimal>(Properties.NameOf(p => p.PaymentAmount), value);
				SendPropertyChanged(Properties.NameOf(p => p.PaymentAmount));
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
			public static string NameOf<T>(Expression<Func<Payment, T>> property)
			{
				return PropertyOf<Payment>.Name<T>(property);
			}
			
			public static PropertyExpression<Payment> Id { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.Id)); } }
			public static PropertyExpression<Payment> PaymentTypeId { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.PaymentTypeId)); } }
			public static PropertyExpression<Payment> CCNumber { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.CCNumber)); } }
			public static PropertyExpression<Payment> Ccid { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.Ccid)); } }
			public static PropertyExpression<Payment> ExpirationMonth { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.ExpirationMonth)); } }
			public static PropertyExpression<Payment> ExpirationYear { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.ExpirationYear)); } }
			public static PropertyExpression<Payment> AuthorizationCode { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.AuthorizationCode)); } }
			public static PropertyExpression<Payment> PaymentAmount { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.PaymentAmount)); } }
			public static PropertyExpression<Payment> CreateDate { get { return new PropertyExpression<Payment>(Properties.NameOf(p => p.CreateDate)); } }
		}
	}
}