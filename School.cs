/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/4/2019
 * Time: 7:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace SchoolManager
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class School
	{
		private Dictionary<int, Teachers> schoolTeachers; 
		private Dictionary<int, Students> schoolStudents;
		private int totalMoneyEarned;
		private int totalMoneySpent;
		public string temp;
		public int option;
		public int studentFind;
		
		
		public School(Dictionary<int, Teachers> teaching, Dictionary<int, Students> learning)
		{
			this.schoolTeachers = teaching;
			this.schoolStudents = learning;
			this.totalMoneyEarned = 0;
			this.totalMoneySpent = 0;
		}
		
		
		public Dictionary<int, Teachers> getTeachingList(){
			return schoolTeachers;
		}
		public void addTeacher(Teachers Teach){
			int tempID = Teach.getEmployeeID();
			schoolTeachers.Add(tempID,Teach);
		}
		public Dictionary<int, Students> getStudentList (){
			return schoolStudents;
		}
		public void addStudent (Students studier){
			int tempID = studier.getID();
			schoolStudents.Add(tempID, studier);
		}
		
		public int getTME(){
			return this.totalMoneyEarned;
		}
		public void updateTME(int income){
			this.totalMoneyEarned += income;
		}
		
		public int getTMS(){
			return this.totalMoneySpent;
		}
		public void UpdateTMS(int expense){
			this.totalMoneyEarned -= expense;
		}
		public void studentController(Dictionary <int, Students> slist){
			
			studentControllers.controlStudents(slist);
		
		}
		
		
		public void teacherController(Dictionary <int, Teachers> tlist){
			
			teacherControllers.controlTeachers(tlist);

		}
		
		
		
		
		
		
	}
}
