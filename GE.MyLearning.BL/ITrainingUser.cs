﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'TrainingUser' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITrainingUser 
	{
		/// <summary>			
		/// TrainUserID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TrainingUser"</remarks>
		System.Int32 TrainUserId { get; set; }
				
		
		
		/// <summary>
		/// UserID : 
		/// </summary>
		System.String  UserId  { get; set; }
		
		/// <summary>
		/// GroupID : 
		/// </summary>
		System.String  GroupId  { get; set; }
		
		/// <summary>
		/// TrainingUserType : 
		/// </summary>
		System.Int32  TrainingUserType  { get; set; }
		
		/// <summary>
		/// TrainUserStatus : 
		/// </summary>
		System.Int32  TrainUserStatus  { get; set; }
		
		/// <summary>
		/// TrainAuditingStatus : 
		/// </summary>
		System.Int32?  TrainAuditingStatus  { get; set; }
		
		/// <summary>
		/// TrainAuditingMan : 
		/// </summary>
		System.String  TrainAuditingMan  { get; set; }
		
		/// <summary>
		/// TrainAuditingDate : 
		/// </summary>
		System.DateTime?  TrainAuditingDate  { get; set; }
		
		/// <summary>
		/// CreateTime : 
		/// </summary>
		System.DateTime?  CreateTime  { get; set; }
		
		/// <summary>
		/// CourseID : 
		/// </summary>
		System.String  CourseId  { get; set; }
		
		/// <summary>
		/// TrainAuditingDescription : 
		/// </summary>
		System.String  TrainAuditingDescription  { get; set; }
		
		/// <summary>
		/// TrainingFinishTime : 
		/// </summary>
		System.DateTime?  TrainingFinishTime  { get; set; }
		
		/// <summary>
		/// TestFinishTime : 
		/// </summary>
		System.DateTime?  TestFinishTime  { get; set; }
		
		/// <summary>
		/// InvestigationFinishTime : 
		/// </summary>
		System.DateTime?  InvestigationFinishTime  { get; set; }
		
		/// <summary>
		/// StudyFinishTime : 
		/// </summary>
		System.DateTime?  StudyFinishTime  { get; set; }
		
		/// <summary>
		/// TrainTimeUseCredit : 
		/// </summary>
		System.Int32?  TrainTimeUseCredit  { get; set; }
		
		/// <summary>
		/// TrainTimeAddPoint : 
		/// </summary>
		System.Int32?  TrainTimeAddPoint  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


