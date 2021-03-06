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

namespace SupportTeamHotline.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SupportTickets")]
	public partial class SupportTicketDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSupportTicket(SupportTicket instance);
    partial void UpdateSupportTicket(SupportTicket instance);
    partial void DeleteSupportTicket(SupportTicket instance);
    partial void InsertTicketCategory(TicketCategory instance);
    partial void UpdateTicketCategory(TicketCategory instance);
    partial void DeleteTicketCategory(TicketCategory instance);
    #endregion
		
		public SupportTicketDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SupportTicketsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SupportTicketDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SupportTicketDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SupportTicketDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SupportTicketDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SupportTicket> SupportTickets
		{
			get
			{
				return this.GetTable<SupportTicket>();
			}
		}
		
		public System.Data.Linq.Table<TicketCategory> TicketCategories
		{
			get
			{
				return this.GetTable<TicketCategory>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SupportTickets")]
	public partial class SupportTicket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TicketId;
		
		private System.Data.Linq.Binary _TicketDateTime;
		
		private string _TicketCreator;
		
		private string _TicketType;
		
		private string _TicketStatus;
		
		private string _Partner;
		
		private string _CallerFName;
		
		private string _CallerLName;
		
		private string _CallerPhone1;
		
		private string _CallerEmail1;
		
		private string _TicketDescription;
		
		private string _TicketResolution;
		
		private string _DevSupport;
		
		private string _IsCallback;
		
		private string _TicketFollowUp;
		
		private System.Nullable<int> _TicketCategoryId;
		
		private System.Nullable<int> _TicketSubCategoryId;
		
		private string _TicketTimeSpent;
		
		private EntityRef<TicketCategory> _TicketCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTicketIdChanging(int value);
    partial void OnTicketIdChanged();
    partial void OnTicketDateTimeChanging(System.Data.Linq.Binary value);
    partial void OnTicketDateTimeChanged();
    partial void OnTicketCreatorChanging(string value);
    partial void OnTicketCreatorChanged();
    partial void OnTicketTypeChanging(string value);
    partial void OnTicketTypeChanged();
    partial void OnTicketStatusChanging(string value);
    partial void OnTicketStatusChanged();
    partial void OnPartnerChanging(string value);
    partial void OnPartnerChanged();
    partial void OnCallerFNameChanging(string value);
    partial void OnCallerFNameChanged();
    partial void OnCallerLNameChanging(string value);
    partial void OnCallerLNameChanged();
    partial void OnCallerPhone1Changing(string value);
    partial void OnCallerPhone1Changed();
    partial void OnCallerEmail1Changing(string value);
    partial void OnCallerEmail1Changed();
    partial void OnTicketDescriptionChanging(string value);
    partial void OnTicketDescriptionChanged();
    partial void OnTicketResolutionChanging(string value);
    partial void OnTicketResolutionChanged();
    partial void OnDevSupportChanging(string value);
    partial void OnDevSupportChanged();
    partial void OnIsCallbackChanging(string value);
    partial void OnIsCallbackChanged();
    partial void OnTicketFollowUpChanging(string value);
    partial void OnTicketFollowUpChanged();
    partial void OnTicketCategoryIdChanging(System.Nullable<int> value);
    partial void OnTicketCategoryIdChanged();
    partial void OnTicketSubCategoryIdChanging(System.Nullable<int> value);
    partial void OnTicketSubCategoryIdChanged();
    partial void OnTicketTimeSpentChanging(string value);
    partial void OnTicketTimeSpentChanged();
    #endregion
		
		public SupportTicket()
		{
			this._TicketCategory = default(EntityRef<TicketCategory>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketId", DbType="Int NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public int TicketId
		{
			get
			{
				return this._TicketId;
			}
			set
			{
				if ((this._TicketId != value))
				{
					this.OnTicketIdChanging(value);
					this.SendPropertyChanging();
					this._TicketId = value;
					this.SendPropertyChanged("TicketId");
					this.OnTicketIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketDateTime", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary TicketDateTime
		{
			get
			{
				return this._TicketDateTime;
			}
			set
			{
				if ((this._TicketDateTime != value))
				{
					this.OnTicketDateTimeChanging(value);
					this.SendPropertyChanging();
					this._TicketDateTime = value;
					this.SendPropertyChanged("TicketDateTime");
					this.OnTicketDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketCreator", DbType="NVarChar(15) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string TicketCreator
		{
			get
			{
				return this._TicketCreator;
			}
			set
			{
				if ((this._TicketCreator != value))
				{
					this.OnTicketCreatorChanging(value);
					this.SendPropertyChanging();
					this._TicketCreator = value;
					this.SendPropertyChanged("TicketCreator");
					this.OnTicketCreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketType", DbType="NVarChar(15)", UpdateCheck=UpdateCheck.Never)]
		public string TicketType
		{
			get
			{
				return this._TicketType;
			}
			set
			{
				if ((this._TicketType != value))
				{
					this.OnTicketTypeChanging(value);
					this.SendPropertyChanging();
					this._TicketType = value;
					this.SendPropertyChanged("TicketType");
					this.OnTicketTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketStatus", DbType="NVarChar(30)", UpdateCheck=UpdateCheck.Never)]
		public string TicketStatus
		{
			get
			{
				return this._TicketStatus;
			}
			set
			{
				if ((this._TicketStatus != value))
				{
					this.OnTicketStatusChanging(value);
					this.SendPropertyChanging();
					this._TicketStatus = value;
					this.SendPropertyChanged("TicketStatus");
					this.OnTicketStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Partner", DbType="NVarChar(30)", UpdateCheck=UpdateCheck.Never)]
		public string Partner
		{
			get
			{
				return this._Partner;
			}
			set
			{
				if ((this._Partner != value))
				{
					this.OnPartnerChanging(value);
					this.SendPropertyChanging();
					this._Partner = value;
					this.SendPropertyChanged("Partner");
					this.OnPartnerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallerFName", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string CallerFName
		{
			get
			{
				return this._CallerFName;
			}
			set
			{
				if ((this._CallerFName != value))
				{
					this.OnCallerFNameChanging(value);
					this.SendPropertyChanging();
					this._CallerFName = value;
					this.SendPropertyChanged("CallerFName");
					this.OnCallerFNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallerLName", DbType="NVarChar(30)", UpdateCheck=UpdateCheck.Never)]
		public string CallerLName
		{
			get
			{
				return this._CallerLName;
			}
			set
			{
				if ((this._CallerLName != value))
				{
					this.OnCallerLNameChanging(value);
					this.SendPropertyChanging();
					this._CallerLName = value;
					this.SendPropertyChanged("CallerLName");
					this.OnCallerLNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallerPhone1", DbType="NVarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string CallerPhone1
		{
			get
			{
				return this._CallerPhone1;
			}
			set
			{
				if ((this._CallerPhone1 != value))
				{
					this.OnCallerPhone1Changing(value);
					this.SendPropertyChanging();
					this._CallerPhone1 = value;
					this.SendPropertyChanged("CallerPhone1");
					this.OnCallerPhone1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallerEmail1", DbType="NVarChar(30)", UpdateCheck=UpdateCheck.Never)]
		public string CallerEmail1
		{
			get
			{
				return this._CallerEmail1;
			}
			set
			{
				if ((this._CallerEmail1 != value))
				{
					this.OnCallerEmail1Changing(value);
					this.SendPropertyChanging();
					this._CallerEmail1 = value;
					this.SendPropertyChanged("CallerEmail1");
					this.OnCallerEmail1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketDescription", DbType="NVarChar(256)", UpdateCheck=UpdateCheck.Never)]
		public string TicketDescription
		{
			get
			{
				return this._TicketDescription;
			}
			set
			{
				if ((this._TicketDescription != value))
				{
					this.OnTicketDescriptionChanging(value);
					this.SendPropertyChanging();
					this._TicketDescription = value;
					this.SendPropertyChanged("TicketDescription");
					this.OnTicketDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketResolution", DbType="NVarChar(256)", UpdateCheck=UpdateCheck.Never)]
		public string TicketResolution
		{
			get
			{
				return this._TicketResolution;
			}
			set
			{
				if ((this._TicketResolution != value))
				{
					this.OnTicketResolutionChanging(value);
					this.SendPropertyChanging();
					this._TicketResolution = value;
					this.SendPropertyChanged("TicketResolution");
					this.OnTicketResolutionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DevSupport", DbType="NVarChar(3)", UpdateCheck=UpdateCheck.Never)]
		public string DevSupport
		{
			get
			{
				return this._DevSupport;
			}
			set
			{
				if ((this._DevSupport != value))
				{
					this.OnDevSupportChanging(value);
					this.SendPropertyChanging();
					this._DevSupport = value;
					this.SendPropertyChanged("DevSupport");
					this.OnDevSupportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsCallback", DbType="NVarChar(3)", UpdateCheck=UpdateCheck.Never)]
		public string IsCallback
		{
			get
			{
				return this._IsCallback;
			}
			set
			{
				if ((this._IsCallback != value))
				{
					this.OnIsCallbackChanging(value);
					this.SendPropertyChanging();
					this._IsCallback = value;
					this.SendPropertyChanged("IsCallback");
					this.OnIsCallbackChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketFollowUp", DbType="NVarChar(3)", UpdateCheck=UpdateCheck.Never)]
		public string TicketFollowUp
		{
			get
			{
				return this._TicketFollowUp;
			}
			set
			{
				if ((this._TicketFollowUp != value))
				{
					this.OnTicketFollowUpChanging(value);
					this.SendPropertyChanging();
					this._TicketFollowUp = value;
					this.SendPropertyChanged("TicketFollowUp");
					this.OnTicketFollowUpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketCategoryId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> TicketCategoryId
		{
			get
			{
				return this._TicketCategoryId;
			}
			set
			{
				if ((this._TicketCategoryId != value))
				{
					this.OnTicketCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._TicketCategoryId = value;
					this.SendPropertyChanged("TicketCategoryId");
					this.OnTicketCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketSubCategoryId", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> TicketSubCategoryId
		{
			get
			{
				return this._TicketSubCategoryId;
			}
			set
			{
				if ((this._TicketSubCategoryId != value))
				{
					this.OnTicketSubCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._TicketSubCategoryId = value;
					this.SendPropertyChanged("TicketSubCategoryId");
					this.OnTicketSubCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketTimeSpent", DbType="NVarChar(3)", UpdateCheck=UpdateCheck.Never)]
		public string TicketTimeSpent
		{
			get
			{
				return this._TicketTimeSpent;
			}
			set
			{
				if ((this._TicketTimeSpent != value))
				{
					this.OnTicketTimeSpentChanging(value);
					this.SendPropertyChanging();
					this._TicketTimeSpent = value;
					this.SendPropertyChanged("TicketTimeSpent");
					this.OnTicketTimeSpentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SupportTicket_TicketCategory", Storage="_TicketCategory", ThisKey="TicketId", OtherKey="TicketCategoryId", IsUnique=true, IsForeignKey=false)]
		public TicketCategory TicketCategory
		{
			get
			{
				return this._TicketCategory.Entity;
			}
			set
			{
				TicketCategory previousValue = this._TicketCategory.Entity;
				if (((previousValue != value) 
							|| (this._TicketCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TicketCategory.Entity = null;
						previousValue.SupportTicket = null;
					}
					this._TicketCategory.Entity = value;
					if ((value != null))
					{
						value.SupportTicket = this;
					}
					this.SendPropertyChanged("TicketCategory");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TicketCategory")]
	public partial class TicketCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TicketCategoryId;
		
		private string _Name;
		
		private EntityRef<SupportTicket> _SupportTicket;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTicketCategoryIdChanging(int value);
    partial void OnTicketCategoryIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public TicketCategory()
		{
			this._SupportTicket = default(EntityRef<SupportTicket>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketCategoryId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TicketCategoryId
		{
			get
			{
				return this._TicketCategoryId;
			}
			set
			{
				if ((this._TicketCategoryId != value))
				{
					if (this._SupportTicket.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTicketCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._TicketCategoryId = value;
					this.SendPropertyChanged("TicketCategoryId");
					this.OnTicketCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SupportTicket_TicketCategory", Storage="_SupportTicket", ThisKey="TicketCategoryId", OtherKey="TicketId", IsForeignKey=true)]
		public SupportTicket SupportTicket
		{
			get
			{
				return this._SupportTicket.Entity;
			}
			set
			{
				SupportTicket previousValue = this._SupportTicket.Entity;
				if (((previousValue != value) 
							|| (this._SupportTicket.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SupportTicket.Entity = null;
						previousValue.TicketCategory = null;
					}
					this._SupportTicket.Entity = value;
					if ((value != null))
					{
						value.TicketCategory = this;
						this._TicketCategoryId = value.TicketId;
					}
					else
					{
						this._TicketCategoryId = default(int);
					}
					this.SendPropertyChanged("SupportTicket");
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
