﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'VU_GroupList' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IVuGroupList 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "VU_GroupList"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// Groupname : 
		/// </summary>
		System.String  Groupname  { get; set; }
		
		/// <summary>
		/// ExeSSO : 
		/// </summary>
		System.String  ExeSso  { get; set; }
		
		/// <summary>
		/// Classid : 
		/// </summary>
		System.String  Classid  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


