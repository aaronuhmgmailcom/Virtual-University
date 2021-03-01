﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'evl_score' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEvlScore 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "evl_score"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// userid : 
		/// </summary>
		System.String  Userid  { get; set; }
		
		/// <summary>
		/// assessmentid : 
		/// </summary>
		System.Int32?  Assessmentid  { get; set; }
		
		/// <summary>
		/// catalog_oneid : 
		/// </summary>
		System.Int32?  CatalogOneid  { get; set; }
		
		/// <summary>
		/// catalog_twoid : 
		/// </summary>
		System.Int32?  CatalogTwoid  { get; set; }
		
		/// <summary>
		/// behaviorid : 
		/// </summary>
		System.Int32?  Behaviorid  { get; set; }
		
		/// <summary>
		/// scorelevel : 
		/// </summary>
		System.Int32?  Scorelevel  { get; set; }
		
		/// <summary>
		/// score : 
		/// </summary>
		System.Decimal?  Score  { get; set; }
		
		/// <summary>
		/// scorereal : 
		/// </summary>
		System.Decimal?  Scorereal  { get; set; }
		
		/// <summary>
		/// model_id : 
		/// </summary>
		System.Int32?  ModelId  { get; set; }
		
		/// <summary>
		/// evlDate : 
		/// </summary>
		System.DateTime  EvlDate  { get; set; }
		
		/// <summary>
		/// evlTimes : 评测次数
		/// </summary>
		System.Int32?  EvlTimes  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


