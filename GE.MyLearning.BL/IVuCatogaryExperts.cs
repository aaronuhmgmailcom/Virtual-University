﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'VU_Catogary_Experts' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IVuCatogaryExperts 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "VU_Catogary_Experts"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// CatogaryID : 
		/// </summary>
		System.Int32?  CatogaryId  { get; set; }
		
		/// <summary>
		/// Owner : 
		/// </summary>
		System.String  Owner  { get; set; }
		
		/// <summary>
		/// email : 
		/// </summary>
		System.String  Email  { get; set; }
		
		/// <summary>
		/// area : 
		/// </summary>
		System.String  Area  { get; set; }
		
		/// <summary>
		/// name : 
		/// </summary>
		System.String  Name  { get; set; }
		
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


