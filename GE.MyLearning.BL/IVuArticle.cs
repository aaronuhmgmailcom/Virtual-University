﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'VU_article' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IVuArticle 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "VU_article"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// classid : 
		/// </summary>
		System.String  Classid  { get; set; }
		
		/// <summary>
		/// biaoti : 
		/// </summary>
		System.String  Biaoti  { get; set; }
		
		/// <summary>
		/// lianjie : 
		/// </summary>
		System.String  Lianjie  { get; set; }
		
		/// <summary>
		/// neirong : 
		/// </summary>
		System.String  Neirong  { get; set; }
		
		/// <summary>
		/// today : 
		/// </summary>
		System.DateTime?  Today  { get; set; }
		
		/// <summary>
		/// sorts : 
		/// </summary>
		System.Int32?  Sorts  { get; set; }
		
		/// <summary>
		/// closed : 
		/// </summary>
		System.Int32?  Closed  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


