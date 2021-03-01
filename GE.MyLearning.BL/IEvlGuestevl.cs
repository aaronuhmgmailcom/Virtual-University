﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'evl_guestevl' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEvlGuestevl 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "evl_guestevl"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// model_id : 
		/// </summary>
		System.Int32?  ModelId  { get; set; }
		
		/// <summary>
		/// assm_id : 
		/// </summary>
		System.Int32?  AssmId  { get; set; }
		
		/// <summary>
		/// email : 
		/// </summary>
		System.String  Email  { get; set; }
		
		/// <summary>
		/// beEvaluationUserID : 
		/// </summary>
		System.String  BeEvaluationUserId  { get; set; }
		
		/// <summary>
		/// link : 
		/// </summary>
		System.String  Link  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


