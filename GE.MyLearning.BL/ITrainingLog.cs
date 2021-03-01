﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'TrainingLog' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITrainingLog 
	{
		/// <summary>			
		/// TrainingLogID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TrainingLog"</remarks>
		System.Int64 TrainingLogId { get; set; }
				
		
		
		/// <summary>
		/// LogBeginTime : 
		/// </summary>
		System.DateTime  LogBeginTime  { get; set; }
		
		/// <summary>
		/// LogEndTime : 
		/// </summary>
		System.DateTime  LogEndTime  { get; set; }
		
		/// <summary>
		/// TrainingTime : 
		/// </summary>
		System.Int32  TrainingTime  { get; set; }
		
		/// <summary>
		/// MachineIP : 
		/// </summary>
		System.String  MachineIp  { get; set; }
		
		/// <summary>
		/// TrainUserID : 
		/// </summary>
		System.Int32  TrainUserId  { get; set; }
		
		/// <summary>
		/// SessionID : 
		/// </summary>
		System.String  SessionId  { get; set; }
		
		/// <summary>
		/// CourseWareID : 
		/// </summary>
		System.String  CourseWareId  { get; set; }
		
		/// <summary>
		/// CourseID : 
		/// </summary>
		System.String  CourseId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


