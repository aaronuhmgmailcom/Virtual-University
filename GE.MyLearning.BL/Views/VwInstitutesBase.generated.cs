﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwInstitutes.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace GE.MyLearning.BL
{
	///<summary>
	/// An object representation of the 'VW_Institutes' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VwInstitutesBase")]
	public abstract partial class VwInstitutesBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// InstituteID : 
		/// </summary>
		private System.String		  _instituteId = string.Empty;
		
		/// <summary>
		/// InstituteName : 
		/// </summary>
		private System.String		  _instituteName = null;
		
		/// <summary>
		/// Description : 
		/// </summary>
		private System.String		  _description = null;
		
		/// <summary>
		/// InstituteDean : 
		/// </summary>
		private System.String		  _instituteDean = null;
		
		/// <summary>
		/// Createtime : 
		/// </summary>
		private System.DateTime?		  _createtime = null;
		
		/// <summary>
		/// CreateUserID : 
		/// </summary>
		private System.String		  _createUserId = string.Empty;
		
		/// <summary>
		/// Status : 
		/// </summary>
		private System.Int32		  _status = (int)0;
		
		/// <summary>
		/// UserID : 
		/// </summary>
		private System.String		  _userId = string.Empty;
		
		/// <summary>
		/// UserName : 
		/// </summary>
		private System.String		  _userName = null;
		
		/// <summary>
		/// UserCNName : 
		/// </summary>
		private System.String		  _userCnName = string.Empty;
		
		/// <summary>
		/// FEBadgeID : 
		/// </summary>
		private System.String		  _feBadgeId = string.Empty;
		
		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;
		
		/// <summary>
		/// Suppresses Entity Events from Firing, 
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized] 
		private bool suppressEntityEvents = false;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="VwInstitutesBase"/> instance.
		///</summary>
		public VwInstitutesBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VwInstitutesBase"/> instance.
		///</summary>
		///<param name="_instituteId"></param>
		///<param name="_instituteName"></param>
		///<param name="_description"></param>
		///<param name="_instituteDean"></param>
		///<param name="_createtime"></param>
		///<param name="_createUserId"></param>
		///<param name="_status"></param>
		///<param name="_userId"></param>
		///<param name="_userName"></param>
		///<param name="_userCnName"></param>
		///<param name="_feBadgeId"></param>
		public VwInstitutesBase(System.String _instituteId, System.String _instituteName, System.String _description, System.String _instituteDean, System.DateTime? _createtime, System.String _createUserId, System.Int32 _status, System.String _userId, System.String _userName, System.String _userCnName, System.String _feBadgeId)
		{
			this._instituteId = _instituteId;
			this._instituteName = _instituteName;
			this._description = _description;
			this._instituteDean = _instituteDean;
			this._createtime = _createtime;
			this._createUserId = _createUserId;
			this._status = _status;
			this._userId = _userId;
			this._userName = _userName;
			this._userCnName = _userCnName;
			this._feBadgeId = _feBadgeId;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VwInstitutes"/> instance.
		///</summary>
		///<param name="_instituteId"></param>
		///<param name="_instituteName"></param>
		///<param name="_description"></param>
		///<param name="_instituteDean"></param>
		///<param name="_createtime"></param>
		///<param name="_createUserId"></param>
		///<param name="_status"></param>
		///<param name="_userId"></param>
		///<param name="_userName"></param>
		///<param name="_userCnName"></param>
		///<param name="_feBadgeId"></param>
		public static VwInstitutes CreateVwInstitutes(System.String _instituteId, System.String _instituteName, System.String _description, System.String _instituteDean, System.DateTime? _createtime, System.String _createUserId, System.Int32 _status, System.String _userId, System.String _userName, System.String _userCnName, System.String _feBadgeId)
		{
			VwInstitutes newVwInstitutes = new VwInstitutes();
			newVwInstitutes.InstituteId = _instituteId;
			newVwInstitutes.InstituteName = _instituteName;
			newVwInstitutes.Description = _description;
			newVwInstitutes.InstituteDean = _instituteDean;
			newVwInstitutes.Createtime = _createtime;
			newVwInstitutes.CreateUserId = _createUserId;
			newVwInstitutes.Status = _status;
			newVwInstitutes.UserId = _userId;
			newVwInstitutes.UserName = _userName;
			newVwInstitutes.UserCnName = _userCnName;
			newVwInstitutes.FeBadgeId = _feBadgeId;
			return newVwInstitutes;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the InstituteID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String InstituteId
		{
			get
			{
				return this._instituteId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "InstituteId does not allow null values.");
				if (_instituteId == value)
					return;
					
				this._instituteId = value;
				this._isDirty = true;
				
				OnPropertyChanged("InstituteId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the InstituteName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String InstituteName
		{
			get
			{
				return this._instituteName; 
			}
			set
			{
				if (_instituteName == value)
					return;
					
				this._instituteName = value;
				this._isDirty = true;
				
				OnPropertyChanged("InstituteName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Description property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Description
		{
			get
			{
				return this._description; 
			}
			set
			{
				if (_description == value)
					return;
					
				this._description = value;
				this._isDirty = true;
				
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the InstituteDean property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String InstituteDean
		{
			get
			{
				return this._instituteDean; 
			}
			set
			{
				if (_instituteDean == value)
					return;
					
				this._instituteDean = value;
				this._isDirty = true;
				
				OnPropertyChanged("InstituteDean");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Createtime property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsCreatetimeNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? Createtime
		{
			get
			{
				return this._createtime; 
			}
			set
			{
				if (_createtime == value && Createtime != null )
					return;
					
				this._createtime = value;
				this._isDirty = true;
				
				OnPropertyChanged("Createtime");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CreateUserID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String CreateUserId
		{
			get
			{
				return this._createUserId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "CreateUserId does not allow null values.");
				if (_createUserId == value)
					return;
					
				this._createUserId = value;
				this._isDirty = true;
				
				OnPropertyChanged("CreateUserId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Status property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 Status
		{
			get
			{
				return this._status; 
			}
			set
			{
				if (_status == value)
					return;
					
				this._status = value;
				this._isDirty = true;
				
				OnPropertyChanged("Status");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the UserID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String UserId
		{
			get
			{
				return this._userId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "UserId does not allow null values.");
				if (_userId == value)
					return;
					
				this._userId = value;
				this._isDirty = true;
				
				OnPropertyChanged("UserId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the UserName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String UserName
		{
			get
			{
				return this._userName; 
			}
			set
			{
				if (_userName == value)
					return;
					
				this._userName = value;
				this._isDirty = true;
				
				OnPropertyChanged("UserName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the UserCNName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String UserCnName
		{
			get
			{
				return this._userCnName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "UserCnName does not allow null values.");
				if (_userCnName == value)
					return;
					
				this._userCnName = value;
				this._isDirty = true;
				
				OnPropertyChanged("UserCnName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the FEBadgeID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String FeBadgeId
		{
			get
			{
				return this._feBadgeId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "FeBadgeId does not allow null values.");
				if (_feBadgeId == value)
					return;
					
				this._feBadgeId = value;
				this._isDirty = true;
				
				OnPropertyChanged("FeBadgeId");
			}
		}
		
		
		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;
		
				this._tag = value;
			}
		}
	
		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}
		

		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "VW_Institutes"; }
		}

		
		#endregion
		
		#region Methods	
		
		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}
		
		
		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}
		
		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed VwInstitutesBase Entity 
		///</summary>
		public virtual VwInstitutesBase Copy()
		{
			//shallow copy entity
			VwInstitutes copy = new VwInstitutes();
				copy.InstituteId = this.InstituteId;
				copy.InstituteName = this.InstituteName;
				copy.Description = this.Description;
				copy.InstituteDean = this.InstituteDean;
				copy.Createtime = this.Createtime;
				copy.CreateUserId = this.CreateUserId;
				copy.Status = this.Status;
				copy.UserId = this.UserId;
				copy.UserName = this.UserName;
				copy.UserCnName = this.UserCnName;
				copy.FeBadgeId = this.FeBadgeId;
			copy.AcceptChanges();
			return (VwInstitutes)copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion
		
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="VwInstitutesBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VwInstitutesBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VwInstitutesBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VwInstitutesBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VwInstitutesBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VwInstitutesBase Object1, VwInstitutesBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.InstituteId != Object2.InstituteId)
				equal = false;
			if (Object1.InstituteName != null && Object2.InstituteName != null )
			{
				if (Object1.InstituteName != Object2.InstituteName)
					equal = false;
			}
			else if (Object1.InstituteName == null ^ Object1.InstituteName == null )
			{
				equal = false;
			}
			if (Object1.Description != null && Object2.Description != null )
			{
				if (Object1.Description != Object2.Description)
					equal = false;
			}
			else if (Object1.Description == null ^ Object1.Description == null )
			{
				equal = false;
			}
			if (Object1.InstituteDean != null && Object2.InstituteDean != null )
			{
				if (Object1.InstituteDean != Object2.InstituteDean)
					equal = false;
			}
			else if (Object1.InstituteDean == null ^ Object1.InstituteDean == null )
			{
				equal = false;
			}
			if (Object1.Createtime != null && Object2.Createtime != null )
			{
				if (Object1.Createtime != Object2.Createtime)
					equal = false;
			}
			else if (Object1.Createtime == null ^ Object1.Createtime == null )
			{
				equal = false;
			}
			if (Object1.CreateUserId != Object2.CreateUserId)
				equal = false;
			if (Object1.Status != Object2.Status)
				equal = false;
			if (Object1.UserId != Object2.UserId)
				equal = false;
			if (Object1.UserName != null && Object2.UserName != null )
			{
				if (Object1.UserName != Object2.UserName)
					equal = false;
			}
			else if (Object1.UserName == null ^ Object1.UserName == null )
			{
				equal = false;
			}
			if (Object1.UserCnName != Object2.UserCnName)
				equal = false;
			if (Object1.FeBadgeId != Object2.FeBadgeId)
				equal = false;
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	
		#endregion
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
		
		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(VwInstitutes entity, string propertyName)
		{
			switch (propertyName)
			{
				case "InstituteId":
					return entity.InstituteId;
				case "InstituteName":
					return entity.InstituteName;
				case "Description":
					return entity.Description;
				case "InstituteDean":
					return entity.InstituteDean;
				case "Createtime":
					return entity.Createtime;
				case "CreateUserId":
					return entity.CreateUserId;
				case "Status":
					return entity.Status;
				case "UserId":
					return entity.UserId;
				case "UserName":
					return entity.UserName;
				case "UserCnName":
					return entity.UserCnName;
				case "FeBadgeId":
					return entity.FeBadgeId;
			}
			return null;
		}
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{			
			return GetPropertyValueByName(this as VwInstitutes, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{12}{11}- InstituteId: {0}{11}- InstituteName: {1}{11}- Description: {2}{11}- InstituteDean: {3}{11}- Createtime: {4}{11}- CreateUserId: {5}{11}- Status: {6}{11}- UserId: {7}{11}- UserName: {8}{11}- UserCnName: {9}{11}- FeBadgeId: {10}{11}", 
				this.InstituteId,
				(this.InstituteName == null) ? string.Empty : this.InstituteName.ToString(),
			     
				(this.Description == null) ? string.Empty : this.Description.ToString(),
			     
				(this.InstituteDean == null) ? string.Empty : this.InstituteDean.ToString(),
			     
				(this.Createtime == null) ? string.Empty : this.Createtime.ToString(),
			     
				this.CreateUserId,
				this.Status,
				this.UserId,
				(this.UserName == null) ? string.Empty : this.UserName.ToString(),
			     
				this.UserCnName,
				this.FeBadgeId,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VwInstitutes columns.
	/// </summary>
	[Serializable]
	public enum VwInstitutesColumn
	{
		/// <summary>
		/// InstituteID : 
		/// </summary>
		[EnumTextValue("InstituteID")]
		[ColumnEnum("InstituteID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		InstituteId,
		/// <summary>
		/// InstituteName : 
		/// </summary>
		[EnumTextValue("InstituteName")]
		[ColumnEnum("InstituteName", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 150)]
		InstituteName,
		/// <summary>
		/// Description : 
		/// </summary>
		[EnumTextValue("Description")]
		[ColumnEnum("Description", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 500)]
		Description,
		/// <summary>
		/// InstituteDean : 
		/// </summary>
		[EnumTextValue("InstituteDean")]
		[ColumnEnum("InstituteDean", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		InstituteDean,
		/// <summary>
		/// Createtime : 
		/// </summary>
		[EnumTextValue("Createtime")]
		[ColumnEnum("Createtime", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		Createtime,
		/// <summary>
		/// CreateUserID : 
		/// </summary>
		[EnumTextValue("CreateUserID")]
		[ColumnEnum("CreateUserID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		CreateUserId,
		/// <summary>
		/// Status : 
		/// </summary>
		[EnumTextValue("Status")]
		[ColumnEnum("Status", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		Status,
		/// <summary>
		/// UserID : 
		/// </summary>
		[EnumTextValue("UserID")]
		[ColumnEnum("UserID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		UserId,
		/// <summary>
		/// UserName : 
		/// </summary>
		[EnumTextValue("UserName")]
		[ColumnEnum("UserName", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		UserName,
		/// <summary>
		/// UserCNName : 
		/// </summary>
		[EnumTextValue("UserCNName")]
		[ColumnEnum("UserCNName", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		UserCnName,
		/// <summary>
		/// FEBadgeID : 
		/// </summary>
		[EnumTextValue("FEBadgeID")]
		[ColumnEnum("FEBadgeID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		FeBadgeId
	}//End enum

} // end namespace
