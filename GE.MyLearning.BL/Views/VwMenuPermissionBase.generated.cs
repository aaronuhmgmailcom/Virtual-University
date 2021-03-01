﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwMenuPermission.cs instead.
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
	/// An object representation of the 'VW_MenuPermission' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VwMenuPermissionBase")]
	public abstract partial class VwMenuPermissionBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MenuID : 
		/// </summary>
		private System.String		  _menuId = string.Empty;
		
		/// <summary>
		/// MenuName : 
		/// </summary>
		private System.String		  _menuName = null;
		
		/// <summary>
		/// MenuStatus : 
		/// </summary>
		private System.Int32		  _menuStatus = (int)0;
		
		/// <summary>
		/// PermissionID : 
		/// </summary>
		private System.String		  _permissionId = string.Empty;
		
		/// <summary>
		/// PermissionName : 
		/// </summary>
		private System.String		  _permissionName = null;
		
		/// <summary>
		/// PermissionURL : 
		/// </summary>
		private System.String		  _permissionUrl = null;
		
		/// <summary>
		/// PermissionStatus : 
		/// </summary>
		private System.Int32		  _permissionStatus = (int)0;
		
		/// <summary>
		/// ParentMenuID : 
		/// </summary>
		private System.String		  _parentMenuId = null;
		
		/// <summary>
		/// ShowOrder : 
		/// </summary>
		private System.Int32?		  _showOrder = null;
		
		/// <summary>
		/// PageUrl : 
		/// </summary>
		private System.String		  _pageUrl = null;
		
		/// <summary>
		/// HelpInfo : 
		/// </summary>
		private System.String		  _helpInfo = null;
		
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
		/// Creates a new <see cref="VwMenuPermissionBase"/> instance.
		///</summary>
		public VwMenuPermissionBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VwMenuPermissionBase"/> instance.
		///</summary>
		///<param name="_menuId"></param>
		///<param name="_menuName"></param>
		///<param name="_menuStatus"></param>
		///<param name="_permissionId"></param>
		///<param name="_permissionName"></param>
		///<param name="_permissionUrl"></param>
		///<param name="_permissionStatus"></param>
		///<param name="_parentMenuId"></param>
		///<param name="_showOrder"></param>
		///<param name="_pageUrl"></param>
		///<param name="_helpInfo"></param>
		public VwMenuPermissionBase(System.String _menuId, System.String _menuName, System.Int32 _menuStatus, System.String _permissionId, System.String _permissionName, System.String _permissionUrl, System.Int32 _permissionStatus, System.String _parentMenuId, System.Int32? _showOrder, System.String _pageUrl, System.String _helpInfo)
		{
			this._menuId = _menuId;
			this._menuName = _menuName;
			this._menuStatus = _menuStatus;
			this._permissionId = _permissionId;
			this._permissionName = _permissionName;
			this._permissionUrl = _permissionUrl;
			this._permissionStatus = _permissionStatus;
			this._parentMenuId = _parentMenuId;
			this._showOrder = _showOrder;
			this._pageUrl = _pageUrl;
			this._helpInfo = _helpInfo;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VwMenuPermission"/> instance.
		///</summary>
		///<param name="_menuId"></param>
		///<param name="_menuName"></param>
		///<param name="_menuStatus"></param>
		///<param name="_permissionId"></param>
		///<param name="_permissionName"></param>
		///<param name="_permissionUrl"></param>
		///<param name="_permissionStatus"></param>
		///<param name="_parentMenuId"></param>
		///<param name="_showOrder"></param>
		///<param name="_pageUrl"></param>
		///<param name="_helpInfo"></param>
		public static VwMenuPermission CreateVwMenuPermission(System.String _menuId, System.String _menuName, System.Int32 _menuStatus, System.String _permissionId, System.String _permissionName, System.String _permissionUrl, System.Int32 _permissionStatus, System.String _parentMenuId, System.Int32? _showOrder, System.String _pageUrl, System.String _helpInfo)
		{
			VwMenuPermission newVwMenuPermission = new VwMenuPermission();
			newVwMenuPermission.MenuId = _menuId;
			newVwMenuPermission.MenuName = _menuName;
			newVwMenuPermission.MenuStatus = _menuStatus;
			newVwMenuPermission.PermissionId = _permissionId;
			newVwMenuPermission.PermissionName = _permissionName;
			newVwMenuPermission.PermissionUrl = _permissionUrl;
			newVwMenuPermission.PermissionStatus = _permissionStatus;
			newVwMenuPermission.ParentMenuId = _parentMenuId;
			newVwMenuPermission.ShowOrder = _showOrder;
			newVwMenuPermission.PageUrl = _pageUrl;
			newVwMenuPermission.HelpInfo = _helpInfo;
			return newVwMenuPermission;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MenuID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MenuId
		{
			get
			{
				return this._menuId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MenuId does not allow null values.");
				if (_menuId == value)
					return;
					
				this._menuId = value;
				this._isDirty = true;
				
				OnPropertyChanged("MenuId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MenuName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MenuName
		{
			get
			{
				return this._menuName; 
			}
			set
			{
				if (_menuName == value)
					return;
					
				this._menuName = value;
				this._isDirty = true;
				
				OnPropertyChanged("MenuName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MenuStatus property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MenuStatus
		{
			get
			{
				return this._menuStatus; 
			}
			set
			{
				if (_menuStatus == value)
					return;
					
				this._menuStatus = value;
				this._isDirty = true;
				
				OnPropertyChanged("MenuStatus");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the PermissionID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String PermissionId
		{
			get
			{
				return this._permissionId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "PermissionId does not allow null values.");
				if (_permissionId == value)
					return;
					
				this._permissionId = value;
				this._isDirty = true;
				
				OnPropertyChanged("PermissionId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the PermissionName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String PermissionName
		{
			get
			{
				return this._permissionName; 
			}
			set
			{
				if (_permissionName == value)
					return;
					
				this._permissionName = value;
				this._isDirty = true;
				
				OnPropertyChanged("PermissionName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the PermissionURL property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String PermissionUrl
		{
			get
			{
				return this._permissionUrl; 
			}
			set
			{
				if (_permissionUrl == value)
					return;
					
				this._permissionUrl = value;
				this._isDirty = true;
				
				OnPropertyChanged("PermissionUrl");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the PermissionStatus property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 PermissionStatus
		{
			get
			{
				return this._permissionStatus; 
			}
			set
			{
				if (_permissionStatus == value)
					return;
					
				this._permissionStatus = value;
				this._isDirty = true;
				
				OnPropertyChanged("PermissionStatus");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ParentMenuID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ParentMenuId
		{
			get
			{
				return this._parentMenuId; 
			}
			set
			{
				if (_parentMenuId == value)
					return;
					
				this._parentMenuId = value;
				this._isDirty = true;
				
				OnPropertyChanged("ParentMenuId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ShowOrder property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsShowOrderNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? ShowOrder
		{
			get
			{
				return this._showOrder; 
			}
			set
			{
				if (_showOrder == value && ShowOrder != null )
					return;
					
				this._showOrder = value;
				this._isDirty = true;
				
				OnPropertyChanged("ShowOrder");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the PageUrl property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String PageUrl
		{
			get
			{
				return this._pageUrl; 
			}
			set
			{
				if (_pageUrl == value)
					return;
					
				this._pageUrl = value;
				this._isDirty = true;
				
				OnPropertyChanged("PageUrl");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the HelpInfo property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HelpInfo
		{
			get
			{
				return this._helpInfo; 
			}
			set
			{
				if (_helpInfo == value)
					return;
					
				this._helpInfo = value;
				this._isDirty = true;
				
				OnPropertyChanged("HelpInfo");
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
			get { return "VW_MenuPermission"; }
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
		///  Returns a Typed VwMenuPermissionBase Entity 
		///</summary>
		public virtual VwMenuPermissionBase Copy()
		{
			//shallow copy entity
			VwMenuPermission copy = new VwMenuPermission();
				copy.MenuId = this.MenuId;
				copy.MenuName = this.MenuName;
				copy.MenuStatus = this.MenuStatus;
				copy.PermissionId = this.PermissionId;
				copy.PermissionName = this.PermissionName;
				copy.PermissionUrl = this.PermissionUrl;
				copy.PermissionStatus = this.PermissionStatus;
				copy.ParentMenuId = this.ParentMenuId;
				copy.ShowOrder = this.ShowOrder;
				copy.PageUrl = this.PageUrl;
				copy.HelpInfo = this.HelpInfo;
			copy.AcceptChanges();
			return (VwMenuPermission)copy;
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
		///<returns>true if toObject is a <see cref="VwMenuPermissionBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VwMenuPermissionBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VwMenuPermissionBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VwMenuPermissionBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VwMenuPermissionBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VwMenuPermissionBase Object1, VwMenuPermissionBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MenuId != Object2.MenuId)
				equal = false;
			if (Object1.MenuName != null && Object2.MenuName != null )
			{
				if (Object1.MenuName != Object2.MenuName)
					equal = false;
			}
			else if (Object1.MenuName == null ^ Object1.MenuName == null )
			{
				equal = false;
			}
			if (Object1.MenuStatus != Object2.MenuStatus)
				equal = false;
			if (Object1.PermissionId != Object2.PermissionId)
				equal = false;
			if (Object1.PermissionName != null && Object2.PermissionName != null )
			{
				if (Object1.PermissionName != Object2.PermissionName)
					equal = false;
			}
			else if (Object1.PermissionName == null ^ Object1.PermissionName == null )
			{
				equal = false;
			}
			if (Object1.PermissionUrl != null && Object2.PermissionUrl != null )
			{
				if (Object1.PermissionUrl != Object2.PermissionUrl)
					equal = false;
			}
			else if (Object1.PermissionUrl == null ^ Object1.PermissionUrl == null )
			{
				equal = false;
			}
			if (Object1.PermissionStatus != Object2.PermissionStatus)
				equal = false;
			if (Object1.ParentMenuId != null && Object2.ParentMenuId != null )
			{
				if (Object1.ParentMenuId != Object2.ParentMenuId)
					equal = false;
			}
			else if (Object1.ParentMenuId == null ^ Object1.ParentMenuId == null )
			{
				equal = false;
			}
			if (Object1.ShowOrder != null && Object2.ShowOrder != null )
			{
				if (Object1.ShowOrder != Object2.ShowOrder)
					equal = false;
			}
			else if (Object1.ShowOrder == null ^ Object1.ShowOrder == null )
			{
				equal = false;
			}
			if (Object1.PageUrl != null && Object2.PageUrl != null )
			{
				if (Object1.PageUrl != Object2.PageUrl)
					equal = false;
			}
			else if (Object1.PageUrl == null ^ Object1.PageUrl == null )
			{
				equal = false;
			}
			if (Object1.HelpInfo != null && Object2.HelpInfo != null )
			{
				if (Object1.HelpInfo != Object2.HelpInfo)
					equal = false;
			}
			else if (Object1.HelpInfo == null ^ Object1.HelpInfo == null )
			{
				equal = false;
			}
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
		public static object GetPropertyValueByName(VwMenuPermission entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MenuId":
					return entity.MenuId;
				case "MenuName":
					return entity.MenuName;
				case "MenuStatus":
					return entity.MenuStatus;
				case "PermissionId":
					return entity.PermissionId;
				case "PermissionName":
					return entity.PermissionName;
				case "PermissionUrl":
					return entity.PermissionUrl;
				case "PermissionStatus":
					return entity.PermissionStatus;
				case "ParentMenuId":
					return entity.ParentMenuId;
				case "ShowOrder":
					return entity.ShowOrder;
				case "PageUrl":
					return entity.PageUrl;
				case "HelpInfo":
					return entity.HelpInfo;
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
			return GetPropertyValueByName(this as VwMenuPermission, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{12}{11}- MenuId: {0}{11}- MenuName: {1}{11}- MenuStatus: {2}{11}- PermissionId: {3}{11}- PermissionName: {4}{11}- PermissionUrl: {5}{11}- PermissionStatus: {6}{11}- ParentMenuId: {7}{11}- ShowOrder: {8}{11}- PageUrl: {9}{11}- HelpInfo: {10}{11}", 
				this.MenuId,
				(this.MenuName == null) ? string.Empty : this.MenuName.ToString(),
			     
				this.MenuStatus,
				this.PermissionId,
				(this.PermissionName == null) ? string.Empty : this.PermissionName.ToString(),
			     
				(this.PermissionUrl == null) ? string.Empty : this.PermissionUrl.ToString(),
			     
				this.PermissionStatus,
				(this.ParentMenuId == null) ? string.Empty : this.ParentMenuId.ToString(),
			     
				(this.ShowOrder == null) ? string.Empty : this.ShowOrder.ToString(),
			     
				(this.PageUrl == null) ? string.Empty : this.PageUrl.ToString(),
			     
				(this.HelpInfo == null) ? string.Empty : this.HelpInfo.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VwMenuPermission columns.
	/// </summary>
	[Serializable]
	public enum VwMenuPermissionColumn
	{
		/// <summary>
		/// MenuID : 
		/// </summary>
		[EnumTextValue("MenuID")]
		[ColumnEnum("MenuID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 40)]
		MenuId,
		/// <summary>
		/// MenuName : 
		/// </summary>
		[EnumTextValue("MenuName")]
		[ColumnEnum("MenuName", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 40)]
		MenuName,
		/// <summary>
		/// MenuStatus : 
		/// </summary>
		[EnumTextValue("MenuStatus")]
		[ColumnEnum("MenuStatus", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MenuStatus,
		/// <summary>
		/// PermissionID : 
		/// </summary>
		[EnumTextValue("PermissionID")]
		[ColumnEnum("PermissionID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 40)]
		PermissionId,
		/// <summary>
		/// PermissionName : 
		/// </summary>
		[EnumTextValue("PermissionName")]
		[ColumnEnum("PermissionName", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 150)]
		PermissionName,
		/// <summary>
		/// PermissionURL : 
		/// </summary>
		[EnumTextValue("PermissionURL")]
		[ColumnEnum("PermissionURL", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 150)]
		PermissionUrl,
		/// <summary>
		/// PermissionStatus : 
		/// </summary>
		[EnumTextValue("PermissionStatus")]
		[ColumnEnum("PermissionStatus", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		PermissionStatus,
		/// <summary>
		/// ParentMenuID : 
		/// </summary>
		[EnumTextValue("ParentMenuID")]
		[ColumnEnum("ParentMenuID", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 40)]
		ParentMenuId,
		/// <summary>
		/// ShowOrder : 
		/// </summary>
		[EnumTextValue("ShowOrder")]
		[ColumnEnum("ShowOrder", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		ShowOrder,
		/// <summary>
		/// PageUrl : 
		/// </summary>
		[EnumTextValue("PageUrl")]
		[ColumnEnum("PageUrl", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 200)]
		PageUrl,
		/// <summary>
		/// HelpInfo : 
		/// </summary>
		[EnumTextValue("HelpInfo")]
		[ColumnEnum("HelpInfo", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 1000)]
		HelpInfo
	}//End enum

} // end namespace
