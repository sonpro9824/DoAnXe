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
	public partial class Ticket_dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertWaiting_Ticket(Waiting_Ticket instance);
    partial void UpdateWaiting_Ticket(Waiting_Ticket instance);
    partial void DeleteWaiting_Ticket(Waiting_Ticket instance);
    #endregion
		
		public Ticket_dbDataContext() : 
				base(global::CarParking.Properties.Settings.Default.Data121ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Ticket_dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Ticket_dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Ticket_dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Ticket_dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Waiting_Ticket> Waiting_Tickets
		{
			get
			{
				return this.GetTable<Waiting_Ticket>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Waiting_Ticket")]
	public partial class Waiting_Ticket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Ticket_ID;
		
		private string _Owner_ID;
		
		private string _Car_ID;
		
		private string _Ticket_type;
		
		private System.Nullable<bool> _Is_Entry_Ticket;
		
		private System.Nullable<System.DateTime> _Time_In;
		
		private System.Nullable<System.DateTime> _Time_Out;
		
		private string _Location_ID;
		
		private System.Nullable<int> _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTicket_IDChanging(string value);
    partial void OnTicket_IDChanged();
    partial void OnOwner_IDChanging(string value);
    partial void OnOwner_IDChanged();
    partial void OnCar_IDChanging(string value);
    partial void OnCar_IDChanged();
    partial void OnTicket_typeChanging(string value);
    partial void OnTicket_typeChanged();
    partial void OnIs_Entry_TicketChanging(System.Nullable<bool> value);
    partial void OnIs_Entry_TicketChanged();
    partial void OnTime_InChanging(System.Nullable<System.DateTime> value);
    partial void OnTime_InChanged();
    partial void OnTime_OutChanging(System.Nullable<System.DateTime> value);
    partial void OnTime_OutChanged();
    partial void OnLocation_IDChanging(string value);
    partial void OnLocation_IDChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    #endregion
		
		public Waiting_Ticket()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ticket_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Ticket_ID
		{
			get
			{
				return this._Ticket_ID;
			}
			set
			{
				if ((this._Ticket_ID != value))
				{
					this.OnTicket_IDChanging(value);
					this.SendPropertyChanging();
					this._Ticket_ID = value;
					this.SendPropertyChanged("Ticket_ID");
					this.OnTicket_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner_ID", DbType="NChar(10)")]
		public string Owner_ID
		{
			get
			{
				return this._Owner_ID;
			}
			set
			{
				if ((this._Owner_ID != value))
				{
					this.OnOwner_IDChanging(value);
					this.SendPropertyChanging();
					this._Owner_ID = value;
					this.SendPropertyChanged("Owner_ID");
					this.OnOwner_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Car_ID", DbType="NChar(10)")]
		public string Car_ID
		{
			get
			{
				return this._Car_ID;
			}
			set
			{
				if ((this._Car_ID != value))
				{
					this.OnCar_IDChanging(value);
					this.SendPropertyChanging();
					this._Car_ID = value;
					this.SendPropertyChanged("Car_ID");
					this.OnCar_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ticket_type", DbType="NChar(10)")]
		public string Ticket_type
		{
			get
			{
				return this._Ticket_type;
			}
			set
			{
				if ((this._Ticket_type != value))
				{
					this.OnTicket_typeChanging(value);
					this.SendPropertyChanging();
					this._Ticket_type = value;
					this.SendPropertyChanged("Ticket_type");
					this.OnTicket_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Is_Entry_Ticket", DbType="Bit")]
		public System.Nullable<bool> Is_Entry_Ticket
		{
			get
			{
				return this._Is_Entry_Ticket;
			}
			set
			{
				if ((this._Is_Entry_Ticket != value))
				{
					this.OnIs_Entry_TicketChanging(value);
					this.SendPropertyChanging();
					this._Is_Entry_Ticket = value;
					this.SendPropertyChanged("Is_Entry_Ticket");
					this.OnIs_Entry_TicketChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time_In", DbType="DateTime")]
		public System.Nullable<System.DateTime> Time_In
		{
			get
			{
				return this._Time_In;
			}
			set
			{
				if ((this._Time_In != value))
				{
					this.OnTime_InChanging(value);
					this.SendPropertyChanging();
					this._Time_In = value;
					this.SendPropertyChanged("Time_In");
					this.OnTime_InChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time_Out", DbType="DateTime")]
		public System.Nullable<System.DateTime> Time_Out
		{
			get
			{
				return this._Time_Out;
			}
			set
			{
				if ((this._Time_Out != value))
				{
					this.OnTime_OutChanging(value);
					this.SendPropertyChanging();
					this._Time_Out = value;
					this.SendPropertyChanged("Time_Out");
					this.OnTime_OutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location_ID", DbType="NChar(10)")]
		public string Location_ID
		{
			get
			{
				return this._Location_ID;
			}
			set
			{
				if ((this._Location_ID != value))
				{
					this.OnLocation_IDChanging(value);
					this.SendPropertyChanging();
					this._Location_ID = value;
					this.SendPropertyChanged("Location_ID");
					this.OnLocation_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
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