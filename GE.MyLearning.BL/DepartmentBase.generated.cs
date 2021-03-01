﻿
/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file Department.cs instead.
*/

#region using directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;

using GE.MyLearning.BL.Validation;
#endregion

namespace GE.MyLearning.BL
{
	///<summary>
	/// An object representation of the 'Department' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class DepartmentBase : EntityBase, IDepartment, IEntityId<DepartmentKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private DepartmentEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private DepartmentEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private DepartmentEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<Department> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event DepartmentEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event DepartmentEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="DepartmentBase"/> instance.
		///</summary>
		public DepartmentBase()
		{
			this.entityData = new DepartmentEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="DepartmentBase"/> instance.
		///</summary>
		///<param name="_departmentName"></param>
		///<param name="_createdDate"></param>
		///<param name="_updatedDate"></param>
		public DepartmentBase(System.String _departmentName, System.DateTime? _createdDate, 
			System.DateTime? _updatedDate)
		{
			this.entityData = new DepartmentEntityData();
			this.backupData = null;

			this.DepartmentName = _departmentName;
			this.CreatedDate = _createdDate;
			this.UpdatedDate = _updatedDate;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="Department"/> instance.
		///</summary>
		///<param name="_departmentName"></param>
		///<param name="_createdDate"></param>
		///<param name="_updatedDate"></param>
		public static Department CreateDepartment(System.String _departmentName, System.DateTime? _createdDate, 
			System.DateTime? _updatedDate)
		{
			Department newDepartment = new Department();
			newDepartment.DepartmentName = _departmentName;
			newDepartment.CreatedDate = _createdDate;
			newDepartment.UpdatedDate = _updatedDate;
			return newDepartment;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the DepartmentName property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[NotNullValidator(MessageTemplate="Property does not allow null values.", Tag="DepartmentName")]
		[ValidatorComposition(CompositionType.And, Tag="DepartmentName")]

		[StringLengthValidator(50, MessageTemplate="Maximum length has been exceeded.", Tag="DepartmentName")]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false, 50)]
		public virtual System.String DepartmentName
		{
			get
			{
				return this.entityData.DepartmentName; 
			}
			
			set
			{
				if (this.entityData.DepartmentName == value)
					return;
					
				OnColumnChanging(DepartmentColumn.DepartmentName, this.entityData.DepartmentName);
				this.entityData.DepartmentName = value;
				this.EntityId.DepartmentName = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(DepartmentColumn.DepartmentName, this.entityData.DepartmentName);
				OnPropertyChanged("DepartmentName");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the DepartmentName property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the DepartmentName property.</remarks>
		/// <value>This type is varchar</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.String OriginalDepartmentName
		{
			get { return this.entityData.OriginalDepartmentName; }
			set { this.entityData.OriginalDepartmentName = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the CreatedDate property. 
		///		
		/// </summary>
		/// <value>This type is datetime.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsCreatedDateNull() and perform business logic appropriately.
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true)]
		public virtual System.DateTime? CreatedDate
		{
			get
			{
				return this.entityData.CreatedDate; 
			}
			
			set
			{
				if (this.entityData.CreatedDate == value)
					return;
					
				OnColumnChanging(DepartmentColumn.CreatedDate, this.entityData.CreatedDate);
				this.entityData.CreatedDate = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(DepartmentColumn.CreatedDate, this.entityData.CreatedDate);
				OnPropertyChanged("CreatedDate");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the UpdatedDate property. 
		///		
		/// </summary>
		/// <value>This type is datetime.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsUpdatedDateNull() and perform business logic appropriately.
		/// </remarks>




		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true)]
		public virtual System.DateTime? UpdatedDate
		{
			get
			{
				return this.entityData.UpdatedDate; 
			}
			
			set
			{
				if (this.entityData.UpdatedDate == value)
					return;
					
				OnColumnChanging(DepartmentColumn.UpdatedDate, this.entityData.UpdatedDate);
				this.entityData.UpdatedDate = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(DepartmentColumn.UpdatedDate, this.entityData.UpdatedDate);
				OnPropertyChanged("UpdatedDate");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
		#endregion Children Collections
		
		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "Department"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"DepartmentName", "CreatedDate", "UpdatedDate"};
			}
		}
		#endregion 
		
		#region IEditableObject
		
		#region  CancelAddNew Event
		/// <summary>
        /// The delegate for the CancelAddNew event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public delegate void CancelAddNewEventHandler(object sender, EventArgs e);
    
    	/// <summary>
		/// The CancelAddNew event.
		/// </summary>
		[field:NonSerialized]
		public event CancelAddNewEventHandler CancelAddNew ;

		/// <summary>
        /// Called when [cancel add new].
        /// </summary>
        public void OnCancelAddNew()
        {    
			if (!SuppressEntityEvents)
			{
	            CancelAddNewEventHandler handler = CancelAddNew ;
            	if (handler != null)
	            {    
    	            handler(this, EventArgs.Empty) ;
        	    }
	        }
        }
		#endregion 
		
		/// <summary>
		/// Begins an edit on an object.
		/// </summary>
		void IEditableObject.BeginEdit() 
	    {
	        //Console.WriteLine("Start BeginEdit");
	        if (!inTxn) 
	        {
	            this.backupData = this.entityData.Clone() as DepartmentEntityData;
	            inTxn = true;
	            //Console.WriteLine("BeginEdit");
	        }
	        //Console.WriteLine("End BeginEdit");
	    }
	
		/// <summary>
		/// Discards changes since the last <c>BeginEdit</c> call.
		/// </summary>
	    void IEditableObject.CancelEdit() 
	    {
	        //Console.WriteLine("Start CancelEdit");
	        if (this.inTxn) 
	        {
	            this.entityData = this.backupData;
	            this.backupData = null;
				this.inTxn = false;

				if (this.bindingIsNew)
	        	//if (this.EntityState == EntityState.Added)
	        	{
					if (this.parentCollection != null)
						this.parentCollection.Remove( (Department) this ) ;
				}	            
	        }
	        //Console.WriteLine("End CancelEdit");
	    }
	
		/// <summary>
		/// Pushes changes since the last <c>BeginEdit</c> or <c>IBindingList.AddNew</c> call into the underlying object.
		/// </summary>
	    void IEditableObject.EndEdit() 
	    {
	        //Console.WriteLine("Start EndEdit" + this.custData.id + this.custData.lastName);
	        if (this.inTxn) 
	        {
	            this.backupData = null;
				if (this.IsDirty) 
				{
					if (this.bindingIsNew) {
						this.EntityState = EntityState.Added;
						this.bindingIsNew = false ;
					}
					else
						if (this.EntityState == EntityState.Unchanged) 
							this.EntityState = EntityState.Changed ;
				}

				this.bindingIsNew = false ;
	            this.inTxn = false;	            
	        }
	        //Console.WriteLine("End EndEdit");
	    }
	    
	    /// <summary>
        /// Gets or sets the parent collection of this current entity, if available.
        /// </summary>
        /// <value>The parent collection.</value>
	    [XmlIgnore]
		[Browsable(false)]
	    public override object ParentCollection
	    {
	        get 
	        {
	            return this.parentCollection;
	        }
	        set 
	        {
	            this.parentCollection = value as TList<Department>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as Department);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed Department Entity 
		///</summary>
		protected virtual Department Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			Department copy = new Department();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.DepartmentName = this.DepartmentName;
					copy.OriginalDepartmentName = this.OriginalDepartmentName;
				copy.CreatedDate = this.CreatedDate;
				copy.UpdatedDate = this.UpdatedDate;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed Department Entity 
		///</summary>
		public virtual Department Copy()
		{
			return this.Copy(null);	
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone()
		{
			return this.Copy(null);
		}
		
		///<summary>
		/// ICloneableEx.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone(IDictionary existingCopies)
		{
			return this.Copy(existingCopies);
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x == null)
				return null;
				
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x, IDictionary existingCopies)
		{
			if (x == null)
				return null;
			
			if (x is ICloneableEx)
			{
				// Return a deep copy of the object
				return ((ICloneableEx)x).Clone(existingCopies);
			}
			else if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable or IClonableEx Interface.");
		}
		
		
		///<summary>
		///  Returns a Typed Department Entity which is a deep copy of the current entity.
		///</summary>
		public virtual Department DeepCopy()
		{
			return EntityHelper.Clone<Department>(this as Department);	
		}
		#endregion
		
		#region Methods	
			
		///<summary>
		/// Revert all changes and restore original values.
		///</summary>
		public override void CancelChanges()
		{
			IEditableObject obj = (IEditableObject) this;
			obj.CancelEdit();

			this.entityData = null;
			if (this._originalData != null)
			{
				this.entityData = this._originalData.Clone() as DepartmentEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new DepartmentEntityData();
			}
		}	
		
		/// <summary>
		/// Accepts the changes made to this object.
		/// </summary>
		/// <remarks>
		/// After calling this method, properties: IsDirty, IsNew are false. IsDeleted flag remains unchanged as it is handled by the parent List.
		/// </remarks>
		public override void AcceptChanges()
		{
			base.AcceptChanges();

			// we keep of the original version of the data
			this._originalData = null;
			this._originalData = this.entityData.Clone() as DepartmentEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(DepartmentColumn column)
		{
			switch(column)
			{
					case DepartmentColumn.DepartmentName:
					return entityData.DepartmentName != _originalData.DepartmentName;
					case DepartmentColumn.CreatedDate:
					return entityData.CreatedDate != _originalData.CreatedDate;
					case DepartmentColumn.UpdatedDate:
					return entityData.UpdatedDate != _originalData.UpdatedDate;
			
				default:
					return false;
			}
		}
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="columnName">The column name.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public override bool IsPropertyChanged(string columnName)
		{
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< DepartmentColumn >(columnName));
		}
		
		/// <summary>
		/// Determines whether the data has changed from original.
		/// </summary>
		/// <returns>
		/// 	<c>true</c> if data has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool HasDataChanged()
		{
			bool result = false;
			result = result || entityData.DepartmentName != _originalData.DepartmentName;
			result = result || entityData.CreatedDate != _originalData.CreatedDate;
			result = result || entityData.UpdatedDate != _originalData.UpdatedDate;
			return result;
		}	
		
		///<summary>
		///  Returns a Department Entity with the original data.
		///</summary>
		public Department GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateDepartment(
				_originalData.DepartmentName,
				_originalData.CreatedDate,
				_originalData.UpdatedDate
				);
				
			return (Department)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="DepartmentBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is DepartmentBase)
				return ValueEquals(this, (DepartmentBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="DepartmentBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.DepartmentName.GetHashCode() ^ 
					((this.CreatedDate == null) ? string.Empty : this.CreatedDate.ToString()).GetHashCode() ^ 
					((this.UpdatedDate == null) ? string.Empty : this.UpdatedDate.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="DepartmentBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(DepartmentBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="DepartmentBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="DepartmentBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="DepartmentBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(DepartmentBase Object1, DepartmentBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.DepartmentName != Object2.DepartmentName)
				equal = false;
			if ( Object1.CreatedDate != null && Object2.CreatedDate != null )
			{
				if (Object1.CreatedDate != Object2.CreatedDate)
					equal = false;
			}
			else if (Object1.CreatedDate == null ^ Object2.CreatedDate == null )
			{
				equal = false;
			}
			if ( Object1.UpdatedDate != null && Object2.UpdatedDate != null )
			{
				if (Object1.UpdatedDate != Object2.UpdatedDate)
					equal = false;
			}
			else if (Object1.UpdatedDate == null ^ Object2.UpdatedDate == null )
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((DepartmentBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static DepartmentComparer GetComparer()
        {
            return new DepartmentComparer();
        }
        */

        // Comparer delegates back to Department
        // Employee uses the integer's default
        // CompareTo method
        /*
        public int CompareTo(Item rhs)
        {
            return this.Id.CompareTo(rhs.Id);
        }
        */

/*
        // Special implementation to be called by custom comparer
        public int CompareTo(Department rhs, DepartmentColumn which)
        {
            switch (which)
            {
            	
            	
            	case DepartmentColumn.DepartmentName:
            		return this.DepartmentName.CompareTo(rhs.DepartmentName);
            		
            		                 
            	
            	
            	case DepartmentColumn.CreatedDate:
            		return this.CreatedDate.Value.CompareTo(rhs.CreatedDate.Value);
            		
            		                 
            	
            	
            	case DepartmentColumn.UpdatedDate:
            		return this.UpdatedDate.Value.CompareTo(rhs.UpdatedDate.Value);
            		
            		                 
            }
            return 0;
        }
        */
	
		#endregion
		
		#region IComponent Members
		
		private ISite _site = null;

		/// <summary>
		/// Gets or Sets the site where this data is located.
		/// </summary>
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public ISite Site
		{
			get{ return this._site; }
			set{ this._site = value; }
		}

		#endregion

		#region IDisposable Members
		
		/// <summary>
		/// Notify those that care when we dispose.
		/// </summary>
		[field:NonSerialized]
		public event System.EventHandler Disposed;

		/// <summary>
		/// Clean up. Nothing here though.
		/// </summary>
		public virtual void Dispose()
		{
			this.parentCollection = null;
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Clean up.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				EventHandler handler = Disposed;
				if (handler != null)
					handler(this, EventArgs.Empty);
			}
		}
		
		#endregion
				
		#region IEntityKey<DepartmentKey> Members
		
		// member variable for the EntityId property
		private DepartmentKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual DepartmentKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new DepartmentKey(this);
				}

				return _entityId;
			}
			set
			{
				if ( value != null )
				{
					value.Entity = this;
				}
				
				_entityId = value;
			}
		}
		
		#endregion
		
		#region EntityState
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false) , XmlIgnoreAttribute()]
		public override EntityState EntityState 
		{ 
			get{ return entityData.EntityState;	 } 
			set{ entityData.EntityState = value; } 
		}
		#endregion 
		
		#region EntityTrackingKey
		///<summary>
		/// Provides the tracking key for the <see cref="EntityLocator"/>
		///</summary>
		[XmlIgnore]
		public override string EntityTrackingKey
		{
			get
			{
				if(entityTrackingKey == null)
					entityTrackingKey = new System.Text.StringBuilder("Department")
					.Append("|").Append( this.DepartmentName.ToString()).ToString();
				return entityTrackingKey;
			}
			set
		    {
		        if (value != null)
                    entityTrackingKey = value;
		    }
		}
		#endregion 
		
		#region ToString Method
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{4}{3}- DepartmentName: {0}{3}- CreatedDate: {1}{3}- UpdatedDate: {2}{3}{5}", 
				this.DepartmentName,
				(this.CreatedDate == null) ? string.Empty : this.CreatedDate.ToString(),
				(this.UpdatedDate == null) ? string.Empty : this.UpdatedDate.ToString(),
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'Department' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class DepartmentEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// DepartmentName : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Department"</remarks>
		public System.String DepartmentName;
			
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		public System.String OriginalDepartmentName;
		
		#endregion
		
		#region Non Primary key(s)
		
		
		/// <summary>
		/// CreatedDate : 
		/// </summary>
		public System.DateTime?		  CreatedDate = null;
		
		/// <summary>
		/// UpdatedDate : 
		/// </summary>
		public System.DateTime?		  UpdatedDate = null;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
		#endregion Variable Declarations
	
		#region Data Properties

		#endregion Data Properties
		
		#region Clone Method

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public Object Clone()
		{
			DepartmentEntityData _tmp = new DepartmentEntityData();
						
			_tmp.DepartmentName = this.DepartmentName;
			_tmp.OriginalDepartmentName = this.OriginalDepartmentName;
			
			_tmp.CreatedDate = this.CreatedDate;
			_tmp.UpdatedDate = this.UpdatedDate;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone(IDictionary existingCopies)
		{
			if (existingCopies == null)
				existingCopies = new Hashtable();
				
			DepartmentEntityData _tmp = new DepartmentEntityData();
						
			_tmp.DepartmentName = this.DepartmentName;
			_tmp.OriginalDepartmentName = this.OriginalDepartmentName;
			
			_tmp.CreatedDate = this.CreatedDate;
			_tmp.UpdatedDate = this.UpdatedDate;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		#endregion Clone Method
		
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public EntityState	EntityState
		{
			get { return currentEntityState;  }
			set { currentEntityState = value; }
		}
	
	}//End struct











		#endregion
		
				
		
		#region Events trigger
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="DepartmentColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(DepartmentColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="DepartmentColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(DepartmentColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="DepartmentColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(DepartmentColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
				EntityManager.StopTracking(entityTrackingKey);
				
			if (!SuppressEntityEvents)
			{
				DepartmentEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new DepartmentEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="DepartmentColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(DepartmentColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				DepartmentEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new DepartmentEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region DepartmentEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="Department"/> object.
	/// </remarks>
	public class DepartmentEventArgs : System.EventArgs
	{
		private DepartmentColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the DepartmentEventArgs class.
		///</summary>
		public DepartmentEventArgs(DepartmentColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the DepartmentEventArgs class.
		///</summary>
		public DepartmentEventArgs(DepartmentColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The DepartmentColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="DepartmentColumn" />
		public DepartmentColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all Department related events.
	///</summary>
	public delegate void DepartmentEventHandler(object sender, DepartmentEventArgs e);
	
	#region DepartmentComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class DepartmentComparer : System.Collections.Generic.IComparer<Department>
	{
		DepartmentColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:DepartmentComparer"/> class.
        /// </summary>
		public DepartmentComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DepartmentComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public DepartmentComparer(DepartmentColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <c cref="Department"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <c cref="Department"/> to compare.</param>
        /// <param name="b">The second <c>Department</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(Department a, Department b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(Department entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(Department a, Department b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public DepartmentColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region DepartmentKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="Department"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class DepartmentKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the DepartmentKey class.
		/// </summary>
		public DepartmentKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the DepartmentKey class.
		/// </summary>
		public DepartmentKey(DepartmentBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.DepartmentName = entity.DepartmentName;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the DepartmentKey class.
		/// </summary>
		public DepartmentKey(System.String _departmentName)
		{
			#region Init Properties

			this.DepartmentName = _departmentName;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private DepartmentBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public DepartmentBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the DepartmentName property
		private System.String _departmentName;
		
		/// <summary>
		/// Gets or sets the DepartmentName property.
		/// </summary>
		public System.String DepartmentName
		{
			get { return _departmentName; }
			set
			{
				if ( this.Entity != null )
					this.Entity.DepartmentName = value;
				
				_departmentName = value;
			}
		}
		
		#endregion

		#region Methods
		
		/// <summary>
		/// Reads values from the supplied <see cref="IDictionary"/> object into
		/// properties of the current object.
		/// </summary>
		/// <param name="values">An <see cref="IDictionary"/> instance that contains
		/// the key/value pairs to be used as property values.</param>
		public override void Load(IDictionary values)
		{
			#region Init Properties

			if ( values != null )
			{
				DepartmentName = ( values["DepartmentName"] != null ) ? (System.String) EntityUtil.ChangeType(values["DepartmentName"], typeof(System.String)) : string.Empty;
			}

			#endregion
		}

		/// <summary>
		/// Creates a new <see cref="IDictionary"/> object and populates it
		/// with the property values of the current object.
		/// </summary>
		/// <returns>A collection of name/value pairs.</returns>
		public override IDictionary ToDictionary()
		{
			IDictionary values = new Hashtable();

			#region Init Dictionary

			values.Add("DepartmentName", DepartmentName);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("DepartmentName: {0}{1}",
								DepartmentName,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region DepartmentColumn Enum
	
	/// <summary>
	/// Enumerate the Department columns.
	/// </summary>
	[Serializable]
	public enum DepartmentColumn : int
	{
		/// <summary>
		/// DepartmentName : 
		/// </summary>
		[EnumTextValue("DepartmentName")]
		[ColumnEnum("DepartmentName", typeof(System.String), System.Data.DbType.AnsiString, true, false, false, 50)]
		DepartmentName = 1,
		/// <summary>
		/// CreatedDate : 
		/// </summary>
		[EnumTextValue("CreatedDate")]
		[ColumnEnum("CreatedDate", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		CreatedDate = 2,
		/// <summary>
		/// UpdatedDate : 
		/// </summary>
		[EnumTextValue("UpdatedDate")]
		[ColumnEnum("UpdatedDate", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		UpdatedDate = 3
	}//End enum

	#endregion DepartmentColumn Enum

} // end namespace
