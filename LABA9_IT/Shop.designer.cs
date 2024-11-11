﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LABA9_IT
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Shop")]
	public partial class ShopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertOwners(Owners instance);
    partial void UpdateOwners(Owners instance);
    partial void DeleteOwners(Owners instance);
    partial void InsertStores(Stores instance);
    partial void UpdateStores(Stores instance);
    partial void DeleteStores(Stores instance);
    #endregion
		
		public ShopDataContext() : 
				base(global::LABA9_IT.Properties.Settings.Default.ShopConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Owners> Owners
		{
			get
			{
				return this.GetTable<Owners>();
			}
		}
		
		public System.Data.Linq.Table<Stores> Stores
		{
			get
			{
				return this.GetTable<Stores>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Owners")]
	public partial class Owners : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FullName;
		
		private string _Address;
		
		private string _Phone;
		
		private decimal _Investment;
		
		private string _RegistrationNumber;
		
		private System.DateTime _RegistrationDate;
		
		private EntitySet<Stores> _Stores;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnInvestmentChanging(decimal value);
    partial void OnInvestmentChanged();
    partial void OnRegistrationNumberChanging(string value);
    partial void OnRegistrationNumberChanged();
    partial void OnRegistrationDateChanging(System.DateTime value);
    partial void OnRegistrationDateChanged();
    #endregion
		
		public Owners()
		{
			this._Stores = new EntitySet<Stores>(new Action<Stores>(this.attach_Stores), new Action<Stores>(this.detach_Stores));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Investment", DbType="Decimal(18,2) NOT NULL")]
		public decimal Investment
		{
			get
			{
				return this._Investment;
			}
			set
			{
				if ((this._Investment != value))
				{
					this.OnInvestmentChanging(value);
					this.SendPropertyChanging();
					this._Investment = value;
					this.SendPropertyChanged("Investment");
					this.OnInvestmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string RegistrationNumber
		{
			get
			{
				return this._RegistrationNumber;
			}
			set
			{
				if ((this._RegistrationNumber != value))
				{
					this.OnRegistrationNumberChanging(value);
					this.SendPropertyChanging();
					this._RegistrationNumber = value;
					this.SendPropertyChanged("RegistrationNumber");
					this.OnRegistrationNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationDate", DbType="Date NOT NULL")]
		public System.DateTime RegistrationDate
		{
			get
			{
				return this._RegistrationDate;
			}
			set
			{
				if ((this._RegistrationDate != value))
				{
					this.OnRegistrationDateChanging(value);
					this.SendPropertyChanging();
					this._RegistrationDate = value;
					this.SendPropertyChanged("RegistrationDate");
					this.OnRegistrationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Owners_Stores", Storage="_Stores", ThisKey="Id", OtherKey="OwnerId")]
		public EntitySet<Stores> Stores
		{
			get
			{
				return this._Stores;
			}
			set
			{
				this._Stores.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Stores(Stores entity)
		{
			this.SendPropertyChanging();
			entity.Owners = this;
		}
		
		private void detach_Stores(Stores entity)
		{
			this.SendPropertyChanging();
			entity.Owners = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Stores")]
	public partial class Stores : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Address;
		
		private string _Phone;
		
		private decimal _Capital;
		
		private string _Profile;
		
		private int _OwnerId;
		
		private EntityRef<Owners> _Owners;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnCapitalChanging(decimal value);
    partial void OnCapitalChanged();
    partial void OnProfileChanging(string value);
    partial void OnProfileChanged();
    partial void OnOwnerIdChanging(int value);
    partial void OnOwnerIdChanged();
    #endregion
		
		public Stores()
		{
			this._Owners = default(EntityRef<Owners>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capital", DbType="Decimal(18,2) NOT NULL")]
		public decimal Capital
		{
			get
			{
				return this._Capital;
			}
			set
			{
				if ((this._Capital != value))
				{
					this.OnCapitalChanging(value);
					this.SendPropertyChanging();
					this._Capital = value;
					this.SendPropertyChanged("Capital");
					this.OnCapitalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profile", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Profile
		{
			get
			{
				return this._Profile;
			}
			set
			{
				if ((this._Profile != value))
				{
					this.OnProfileChanging(value);
					this.SendPropertyChanging();
					this._Profile = value;
					this.SendPropertyChanged("Profile");
					this.OnProfileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerId", DbType="Int NOT NULL")]
		public int OwnerId
		{
			get
			{
				return this._OwnerId;
			}
			set
			{
				if ((this._OwnerId != value))
				{
					if (this._Owners.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOwnerIdChanging(value);
					this.SendPropertyChanging();
					this._OwnerId = value;
					this.SendPropertyChanged("OwnerId");
					this.OnOwnerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Owners_Stores", Storage="_Owners", ThisKey="OwnerId", OtherKey="Id", IsForeignKey=true)]
		public Owners Owners
		{
			get
			{
				return this._Owners.Entity;
			}
			set
			{
				Owners previousValue = this._Owners.Entity;
				if (((previousValue != value) 
							|| (this._Owners.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Owners.Entity = null;
						previousValue.Stores.Remove(this);
					}
					this._Owners.Entity = value;
					if ((value != null))
					{
						value.Stores.Add(this);
						this._OwnerId = value.Id;
					}
					else
					{
						this._OwnerId = default(int);
					}
					this.SendPropertyChanged("Owners");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591