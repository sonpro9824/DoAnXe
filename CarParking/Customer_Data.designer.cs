﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarParking
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Data121")]
	public partial class Customer_DataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public Customer_DataDataContext() : 
				base(global::CarParking.Properties.Settings.Default.Data121ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Customer_DataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Customer_DataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Customer_DataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Customer_DataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _First_Name;
		
		private System.Nullable<System.DateTime> _Date_of_birth;
		
		private string _Last_Name;
		
		private string _Phone_number;
		
		private string _Email;
		
		private string _Address;
		
		private string _Sex;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnDate_of_birthChanging(System.Nullable<System.DateTime> value);
    partial void OnDate_of_birthChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnPhone_numberChanging(string value);
    partial void OnPhone_numberChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="NVarChar(50)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Date of birth]", Storage="_Date_of_birth", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date_of_birth
		{
			get
			{
				return this._Date_of_birth;
			}
			set
			{
				if ((this._Date_of_birth != value))
				{
					this.OnDate_of_birthChanging(value);
					this.SendPropertyChanging();
					this._Date_of_birth = value;
					this.SendPropertyChanged("Date_of_birth");
					this.OnDate_of_birthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last Name]", Storage="_Last_Name", DbType="NVarChar(50)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Phone number]", Storage="_Phone_number", DbType="NVarChar(50)")]
		public string Phone_number
		{
			get
			{
				return this._Phone_number;
			}
			set
			{
				if ((this._Phone_number != value))
				{
					this.OnPhone_numberChanging(value);
					this.SendPropertyChanging();
					this._Phone_number = value;
					this.SendPropertyChanged("Phone_number");
					this.OnPhone_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NVarChar(50)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
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
