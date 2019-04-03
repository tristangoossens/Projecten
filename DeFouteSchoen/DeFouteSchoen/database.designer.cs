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

namespace DeFouteSchoen
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="defouteschoen")]
	public partial class databaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbeertype(beertype instance);
    partial void Updatebeertype(beertype instance);
    partial void Deletebeertype(beertype instance);
    partial void Insertbeer(beer instance);
    partial void Updatebeer(beer instance);
    partial void Deletebeer(beer instance);
    partial void Insertpurchase(purchase instance);
    partial void Updatepurchase(purchase instance);
    partial void Deletepurchase(purchase instance);
    #endregion
		
		public databaseDataContext() : 
				base(global::DeFouteSchoen.Properties.Settings.Default.defouteschoenConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<beertype> beertypes
		{
			get
			{
				return this.GetTable<beertype>();
			}
		}
		
		public System.Data.Linq.Table<beer> beers
		{
			get
			{
				return this.GetTable<beer>();
			}
		}
		
		public System.Data.Linq.Table<purchase> purchases
		{
			get
			{
				return this.GetTable<purchase>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.beertype")]
	public partial class beertype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _type;
		
		private EntitySet<beer> _beers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    #endregion
		
		public beertype()
		{
			this._beers = new EntitySet<beer>(new Action<beer>(this.attach_beers), new Action<beer>(this.detach_beers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="beertype_beer", Storage="_beers", ThisKey="id", OtherKey="beertypeid")]
		public EntitySet<beer> beers
		{
			get
			{
				return this._beers;
			}
			set
			{
				this._beers.Assign(value);
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
		
		private void attach_beers(beer entity)
		{
			this.SendPropertyChanging();
			entity.beertype = this;
		}
		
		private void detach_beers(beer entity)
		{
			this.SendPropertyChanging();
			entity.beertype = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.beer")]
	public partial class beer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private decimal _price;
		
		private int _purchasecount;
		
		private int _beertypeid;
		
		private EntitySet<purchase> _purchases;
		
		private EntityRef<beertype> _beertype;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnpurchasecountChanging(int value);
    partial void OnpurchasecountChanged();
    partial void OnbeertypeidChanging(int value);
    partial void OnbeertypeidChanged();
    #endregion
		
		public beer()
		{
			this._purchases = new EntitySet<purchase>(new Action<purchase>(this.attach_purchases), new Action<purchase>(this.detach_purchases));
			this._beertype = default(EntityRef<beertype>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(18,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchasecount", DbType="Int NOT NULL")]
		public int purchasecount
		{
			get
			{
				return this._purchasecount;
			}
			set
			{
				if ((this._purchasecount != value))
				{
					this.OnpurchasecountChanging(value);
					this.SendPropertyChanging();
					this._purchasecount = value;
					this.SendPropertyChanged("purchasecount");
					this.OnpurchasecountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_beertypeid", DbType="Int NOT NULL")]
		public int beertypeid
		{
			get
			{
				return this._beertypeid;
			}
			set
			{
				if ((this._beertypeid != value))
				{
					if (this._beertype.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbeertypeidChanging(value);
					this.SendPropertyChanging();
					this._beertypeid = value;
					this.SendPropertyChanged("beertypeid");
					this.OnbeertypeidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="beer_purchase", Storage="_purchases", ThisKey="id", OtherKey="beerid")]
		public EntitySet<purchase> purchases
		{
			get
			{
				return this._purchases;
			}
			set
			{
				this._purchases.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="beertype_beer", Storage="_beertype", ThisKey="beertypeid", OtherKey="id", IsForeignKey=true)]
		public beertype beertype
		{
			get
			{
				return this._beertype.Entity;
			}
			set
			{
				beertype previousValue = this._beertype.Entity;
				if (((previousValue != value) 
							|| (this._beertype.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._beertype.Entity = null;
						previousValue.beers.Remove(this);
					}
					this._beertype.Entity = value;
					if ((value != null))
					{
						value.beers.Add(this);
						this._beertypeid = value.id;
					}
					else
					{
						this._beertypeid = default(int);
					}
					this.SendPropertyChanged("beertype");
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
		
		private void attach_purchases(purchase entity)
		{
			this.SendPropertyChanging();
			entity.beer = this;
		}
		
		private void detach_purchases(purchase entity)
		{
			this.SendPropertyChanging();
			entity.beer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.purchase")]
	public partial class purchase : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _beerid;
		
		private System.DateTime _date;
		
		private int _amount;
		
		private EntityRef<beer> _beer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnbeeridChanging(int value);
    partial void OnbeeridChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnamountChanging(int value);
    partial void OnamountChanged();
    #endregion
		
		public purchase()
		{
			this._beer = default(EntityRef<beer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_beerid", DbType="Int NOT NULL")]
		public int beerid
		{
			get
			{
				return this._beerid;
			}
			set
			{
				if ((this._beerid != value))
				{
					if (this._beer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbeeridChanging(value);
					this.SendPropertyChanging();
					this._beerid = value;
					this.SendPropertyChanged("beerid");
					this.OnbeeridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int NOT NULL")]
		public int amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="beer_purchase", Storage="_beer", ThisKey="beerid", OtherKey="id", IsForeignKey=true)]
		public beer beer
		{
			get
			{
				return this._beer.Entity;
			}
			set
			{
				beer previousValue = this._beer.Entity;
				if (((previousValue != value) 
							|| (this._beer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._beer.Entity = null;
						previousValue.purchases.Remove(this);
					}
					this._beer.Entity = value;
					if ((value != null))
					{
						value.purchases.Add(this);
						this._beerid = value.id;
					}
					else
					{
						this._beerid = default(int);
					}
					this.SendPropertyChanged("beer");
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