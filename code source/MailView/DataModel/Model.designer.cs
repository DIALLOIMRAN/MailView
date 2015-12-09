﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18408
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MailView.DataModel
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MailView")]
	public partial class ModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertMail(Mail instance);
    partial void UpdateMail(Mail instance);
    partial void DeleteMail(Mail instance);
    partial void InsertMailBox(MailBox instance);
    partial void UpdateMailBox(MailBox instance);
    partial void DeleteMailBox(MailBox instance);
    partial void InsertMailBoxMail(MailBoxMail instance);
    partial void UpdateMailBoxMail(MailBoxMail instance);
    partial void DeleteMailBoxMail(MailBoxMail instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUserUser(UserUser instance);
    partial void UpdateUserUser(UserUser instance);
    partial void DeleteUserUser(UserUser instance);
    #endregion
		
		public ModelDataContext() : 
				base(global::MailView.Properties.Settings.Default.MailViewConnectionString7, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Mail> Mail
		{
			get
			{
				return this.GetTable<Mail>();
			}
		}
		
		public System.Data.Linq.Table<MailBox> MailBox
		{
			get
			{
				return this.GetTable<MailBox>();
			}
		}
		
		public System.Data.Linq.Table<MailBoxMail> MailBoxMail
		{
			get
			{
				return this.GetTable<MailBoxMail>();
			}
		}
		
		public System.Data.Linq.Table<User> User
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserUser> UserUser
		{
			get
			{
				return this.GetTable<UserUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mail")]
	public partial class Mail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_mail;
		
		private string _adresse_source;
		
		private string _adresse_dest;
		
		private string _objet;
		
		private string _contenu;
		
		private System.DateTime _date_msg;
		
		private int _etat_msg;
		
		private EntitySet<MailBoxMail> _MailBoxMail;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_mailChanging(int value);
    partial void OnId_mailChanged();
    partial void Onadresse_sourceChanging(string value);
    partial void Onadresse_sourceChanged();
    partial void Onadresse_destChanging(string value);
    partial void Onadresse_destChanged();
    partial void OnobjetChanging(string value);
    partial void OnobjetChanged();
    partial void OncontenuChanging(string value);
    partial void OncontenuChanged();
    partial void Ondate_msgChanging(System.DateTime value);
    partial void Ondate_msgChanged();
    partial void Onetat_msgChanging(int value);
    partial void Onetat_msgChanged();
    #endregion
		
		public Mail()
		{
			this._MailBoxMail = new EntitySet<MailBoxMail>(new Action<MailBoxMail>(this.attach_MailBoxMail), new Action<MailBoxMail>(this.detach_MailBoxMail));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_mail", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_mail
		{
			get
			{
				return this._Id_mail;
			}
			set
			{
				if ((this._Id_mail != value))
				{
					this.OnId_mailChanging(value);
					this.SendPropertyChanging();
					this._Id_mail = value;
					this.SendPropertyChanged("Id_mail");
					this.OnId_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresse_source", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string adresse_source
		{
			get
			{
				return this._adresse_source;
			}
			set
			{
				if ((this._adresse_source != value))
				{
					this.Onadresse_sourceChanging(value);
					this.SendPropertyChanging();
					this._adresse_source = value;
					this.SendPropertyChanged("adresse_source");
					this.Onadresse_sourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresse_dest", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string adresse_dest
		{
			get
			{
				return this._adresse_dest;
			}
			set
			{
				if ((this._adresse_dest != value))
				{
					this.Onadresse_destChanging(value);
					this.SendPropertyChanging();
					this._adresse_dest = value;
					this.SendPropertyChanged("adresse_dest");
					this.Onadresse_destChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objet", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string objet
		{
			get
			{
				return this._objet;
			}
			set
			{
				if ((this._objet != value))
				{
					this.OnobjetChanging(value);
					this.SendPropertyChanging();
					this._objet = value;
					this.SendPropertyChanged("objet");
					this.OnobjetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contenu", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string contenu
		{
			get
			{
				return this._contenu;
			}
			set
			{
				if ((this._contenu != value))
				{
					this.OncontenuChanging(value);
					this.SendPropertyChanging();
					this._contenu = value;
					this.SendPropertyChanged("contenu");
					this.OncontenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_msg", DbType="DateTime NOT NULL")]
		public System.DateTime date_msg
		{
			get
			{
				return this._date_msg;
			}
			set
			{
				if ((this._date_msg != value))
				{
					this.Ondate_msgChanging(value);
					this.SendPropertyChanging();
					this._date_msg = value;
					this.SendPropertyChanged("date_msg");
					this.Ondate_msgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_etat_msg", DbType="Int NOT NULL")]
		public int etat_msg
		{
			get
			{
				return this._etat_msg;
			}
			set
			{
				if ((this._etat_msg != value))
				{
					this.Onetat_msgChanging(value);
					this.SendPropertyChanging();
					this._etat_msg = value;
					this.SendPropertyChanged("etat_msg");
					this.Onetat_msgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mail_MailBoxMail", Storage="_MailBoxMail", ThisKey="Id_mail", OtherKey="Mail_Id_mail")]
		public EntitySet<MailBoxMail> MailBoxMail
		{
			get
			{
				return this._MailBoxMail;
			}
			set
			{
				this._MailBoxMail.Assign(value);
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
		
		private void attach_MailBoxMail(MailBoxMail entity)
		{
			this.SendPropertyChanging();
			entity.Mail = this;
		}
		
		private void detach_MailBoxMail(MailBoxMail entity)
		{
			this.SendPropertyChanging();
			entity.Mail = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MailBox")]
	public partial class MailBox : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_mailbox;
		
		private string _libellé;
		
		private int _UserId_user;
		
		private EntitySet<MailBoxMail> _MailBoxMail;
		
		private EntityRef<User> _User;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_mailboxChanging(int value);
    partial void OnId_mailboxChanged();
    partial void OnlibelléChanging(string value);
    partial void OnlibelléChanged();
    partial void OnUserId_userChanging(int value);
    partial void OnUserId_userChanged();
    #endregion
		
		public MailBox()
		{
			this._MailBoxMail = new EntitySet<MailBoxMail>(new Action<MailBoxMail>(this.attach_MailBoxMail), new Action<MailBoxMail>(this.detach_MailBoxMail));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_mailbox", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_mailbox
		{
			get
			{
				return this._Id_mailbox;
			}
			set
			{
				if ((this._Id_mailbox != value))
				{
					this.OnId_mailboxChanging(value);
					this.SendPropertyChanging();
					this._Id_mailbox = value;
					this.SendPropertyChanged("Id_mailbox");
					this.OnId_mailboxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_libellé", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string libellé
		{
			get
			{
				return this._libellé;
			}
			set
			{
				if ((this._libellé != value))
				{
					this.OnlibelléChanging(value);
					this.SendPropertyChanging();
					this._libellé = value;
					this.SendPropertyChanged("libellé");
					this.OnlibelléChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId_user", DbType="Int NOT NULL")]
		public int UserId_user
		{
			get
			{
				return this._UserId_user;
			}
			set
			{
				if ((this._UserId_user != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserId_userChanging(value);
					this.SendPropertyChanging();
					this._UserId_user = value;
					this.SendPropertyChanged("UserId_user");
					this.OnUserId_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MailBox_MailBoxMail", Storage="_MailBoxMail", ThisKey="Id_mailbox", OtherKey="MailBox_Id_mailbox")]
		public EntitySet<MailBoxMail> MailBoxMail
		{
			get
			{
				return this._MailBoxMail;
			}
			set
			{
				this._MailBoxMail.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_MailBox", Storage="_User", ThisKey="UserId_user", OtherKey="Id_user", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.MailBox.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.MailBox.Add(this);
						this._UserId_user = value.Id_user;
					}
					else
					{
						this._UserId_user = default(int);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_MailBoxMail(MailBoxMail entity)
		{
			this.SendPropertyChanging();
			entity.MailBox = this;
		}
		
		private void detach_MailBoxMail(MailBoxMail entity)
		{
			this.SendPropertyChanging();
			entity.MailBox = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MailBoxMail")]
	public partial class MailBoxMail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MailBox_Id_mailbox;
		
		private int _Mail_Id_mail;
		
		private EntityRef<Mail> _Mail;
		
		private EntityRef<MailBox> _MailBox;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMailBox_Id_mailboxChanging(int value);
    partial void OnMailBox_Id_mailboxChanged();
    partial void OnMail_Id_mailChanging(int value);
    partial void OnMail_Id_mailChanged();
    #endregion
		
		public MailBoxMail()
		{
			this._Mail = default(EntityRef<Mail>);
			this._MailBox = default(EntityRef<MailBox>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailBox_Id_mailbox", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MailBox_Id_mailbox
		{
			get
			{
				return this._MailBox_Id_mailbox;
			}
			set
			{
				if ((this._MailBox_Id_mailbox != value))
				{
					if (this._MailBox.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMailBox_Id_mailboxChanging(value);
					this.SendPropertyChanging();
					this._MailBox_Id_mailbox = value;
					this.SendPropertyChanged("MailBox_Id_mailbox");
					this.OnMailBox_Id_mailboxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail_Id_mail", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Mail_Id_mail
		{
			get
			{
				return this._Mail_Id_mail;
			}
			set
			{
				if ((this._Mail_Id_mail != value))
				{
					if (this._Mail.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMail_Id_mailChanging(value);
					this.SendPropertyChanging();
					this._Mail_Id_mail = value;
					this.SendPropertyChanged("Mail_Id_mail");
					this.OnMail_Id_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mail_MailBoxMail", Storage="_Mail", ThisKey="Mail_Id_mail", OtherKey="Id_mail", IsForeignKey=true)]
		public Mail Mail
		{
			get
			{
				return this._Mail.Entity;
			}
			set
			{
				Mail previousValue = this._Mail.Entity;
				if (((previousValue != value) 
							|| (this._Mail.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Mail.Entity = null;
						previousValue.MailBoxMail.Remove(this);
					}
					this._Mail.Entity = value;
					if ((value != null))
					{
						value.MailBoxMail.Add(this);
						this._Mail_Id_mail = value.Id_mail;
					}
					else
					{
						this._Mail_Id_mail = default(int);
					}
					this.SendPropertyChanged("Mail");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MailBox_MailBoxMail", Storage="_MailBox", ThisKey="MailBox_Id_mailbox", OtherKey="Id_mailbox", IsForeignKey=true)]
		public MailBox MailBox
		{
			get
			{
				return this._MailBox.Entity;
			}
			set
			{
				MailBox previousValue = this._MailBox.Entity;
				if (((previousValue != value) 
							|| (this._MailBox.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MailBox.Entity = null;
						previousValue.MailBoxMail.Remove(this);
					}
					this._MailBox.Entity = value;
					if ((value != null))
					{
						value.MailBoxMail.Add(this);
						this._MailBox_Id_mailbox = value.Id_mailbox;
					}
					else
					{
						this._MailBox_Id_mailbox = default(int);
					}
					this.SendPropertyChanged("MailBox");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_user;
		
		private string _nom;
		
		private string _prenom;
		
		private string _adresse_email;
		
		private string _password;
		
		private string _sexe;
		
		private System.Nullable<int> _connecté;
		
		private byte[] _photo;
		
		private string _numTelephone;
		
		private EntitySet<MailBox> _MailBox;
		
		private EntitySet<UserUser> _UserUser;
		
		private EntitySet<UserUser> _UserUser1;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_userChanging(int value);
    partial void OnId_userChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void Onadresse_emailChanging(string value);
    partial void Onadresse_emailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnsexeChanging(string value);
    partial void OnsexeChanged();
    partial void OnconnectéChanging(System.Nullable<int> value);
    partial void OnconnectéChanged();
    partial void OnphotoChanging(byte[] value);
    partial void OnphotoChanged();
    partial void OnnumTelephoneChanging(string value);
    partial void OnnumTelephoneChanged();
    #endregion
		
		public User()
		{
			this._MailBox = new EntitySet<MailBox>(new Action<MailBox>(this.attach_MailBox), new Action<MailBox>(this.detach_MailBox));
			this._UserUser = new EntitySet<UserUser>(new Action<UserUser>(this.attach_UserUser), new Action<UserUser>(this.detach_UserUser));
			this._UserUser1 = new EntitySet<UserUser>(new Action<UserUser>(this.attach_UserUser1), new Action<UserUser>(this.detach_UserUser1));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_user", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_user
		{
			get
			{
				return this._Id_user;
			}
			set
			{
				if ((this._Id_user != value))
				{
					this.OnId_userChanging(value);
					this.SendPropertyChanging();
					this._Id_user = value;
					this.SendPropertyChanged("Id_user");
					this.OnId_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresse_email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string adresse_email
		{
			get
			{
				return this._adresse_email;
			}
			set
			{
				if ((this._adresse_email != value))
				{
					this.Onadresse_emailChanging(value);
					this.SendPropertyChanging();
					this._adresse_email = value;
					this.SendPropertyChanged("adresse_email");
					this.Onadresse_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexe", DbType="VarChar(2)")]
		public string sexe
		{
			get
			{
				return this._sexe;
			}
			set
			{
				if ((this._sexe != value))
				{
					this.OnsexeChanging(value);
					this.SendPropertyChanging();
					this._sexe = value;
					this.SendPropertyChanged("sexe");
					this.OnsexeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_connecté", DbType="Int")]
		public System.Nullable<int> connecté
		{
			get
			{
				return this._connecté;
			}
			set
			{
				if ((this._connecté != value))
				{
					this.OnconnectéChanging(value);
					this.SendPropertyChanging();
					this._connecté = value;
					this.SendPropertyChanged("connecté");
					this.OnconnectéChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public byte[] photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this.OnphotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("photo");
					this.OnphotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numTelephone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string numTelephone
		{
			get
			{
				return this._numTelephone;
			}
			set
			{
				if ((this._numTelephone != value))
				{
					this.OnnumTelephoneChanging(value);
					this.SendPropertyChanging();
					this._numTelephone = value;
					this.SendPropertyChanged("numTelephone");
					this.OnnumTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_MailBox", Storage="_MailBox", ThisKey="Id_user", OtherKey="UserId_user")]
		public EntitySet<MailBox> MailBox
		{
			get
			{
				return this._MailBox;
			}
			set
			{
				this._MailBox.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserUser", Storage="_UserUser", ThisKey="Id_user", OtherKey="User1_Id_user")]
		public EntitySet<UserUser> UserUser
		{
			get
			{
				return this._UserUser;
			}
			set
			{
				this._UserUser.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserUser1", Storage="_UserUser1", ThisKey="Id_user", OtherKey="User2_Id_user")]
		public EntitySet<UserUser> UserUser1
		{
			get
			{
				return this._UserUser1;
			}
			set
			{
				this._UserUser1.Assign(value);
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
		
		private void attach_MailBox(MailBox entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_MailBox(MailBox entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_UserUser(UserUser entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserUser(UserUser entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_UserUser1(UserUser entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_UserUser1(UserUser entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserUser")]
	public partial class UserUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User1_Id_user;
		
		private int _User2_Id_user;
		
		private EntityRef<User> _User;
		
		private EntityRef<User> _User1;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser1_Id_userChanging(int value);
    partial void OnUser1_Id_userChanged();
    partial void OnUser2_Id_userChanging(int value);
    partial void OnUser2_Id_userChanged();
    #endregion
		
		public UserUser()
		{
			this._User = default(EntityRef<User>);
			this._User1 = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User1_Id_user", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User1_Id_user
		{
			get
			{
				return this._User1_Id_user;
			}
			set
			{
				if ((this._User1_Id_user != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser1_Id_userChanging(value);
					this.SendPropertyChanging();
					this._User1_Id_user = value;
					this.SendPropertyChanged("User1_Id_user");
					this.OnUser1_Id_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User2_Id_user", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User2_Id_user
		{
			get
			{
				return this._User2_Id_user;
			}
			set
			{
				if ((this._User2_Id_user != value))
				{
					if (this._User1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser2_Id_userChanging(value);
					this.SendPropertyChanging();
					this._User2_Id_user = value;
					this.SendPropertyChanged("User2_Id_user");
					this.OnUser2_Id_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserUser", Storage="_User", ThisKey="User1_Id_user", OtherKey="Id_user", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserUser.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserUser.Add(this);
						this._User1_Id_user = value.Id_user;
					}
					else
					{
						this._User1_Id_user = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserUser1", Storage="_User1", ThisKey="User2_Id_user", OtherKey="Id_user", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.UserUser1.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.UserUser1.Add(this);
						this._User2_Id_user = value.Id_user;
					}
					else
					{
						this._User2_Id_user = default(int);
					}
					this.SendPropertyChanged("User1");
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