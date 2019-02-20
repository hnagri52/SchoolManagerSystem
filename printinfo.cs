/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/13/2019
 * Time: 11:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace SchoolManager
{

	public static class printInfo
	{
				
		public static void printALLInfo(Dictionary <int, Teachers> teacherlist, Dictionary <int, Students> studentlist){
		
			
			Console.WriteLine("\n\nHere is a list of all the teachers and the information we have on them: ");
			
		Teachers x = new Teachers();
		foreach(KeyValuePair<int, Teachers> entry in teacherlist){
			x = entry.Value;
			Console.WriteLine("Teacher name: " + x.getName() + ", Employee ID: "+ x.getEmployeeID() + ", Salary: "+ x.getSalary() + ", Vacation days: " + x.getVcnDays());
			 }
		
		Students s = new Students();
		foreach(KeyValuePair<int, Students> entry in studentlist){
			s = entry.Value;
			Console.WriteLine("Student name: " + s.getName() + ", Student ID: " + s.getID() + ", Fees Owed: " + s.getNum() + ", Average: " + s.getGrade()    );
			 }
			
			
		}
	}

}

//printInfo(teacherList, studentList);
			
//		
		
//		Teachers x = new Teachers();
//		foreach(KeyValuePair<int, Teachers> entry in teacherList){
//			x = entry.Value;
//			Console.WriteLine("Teacher name: " + x.getName() + ", Employee ID: "+ x.getEmployeeID() + ", Salary: "+ x.getSalary());
//			 }
//		
//		Students s = new Students();
//		foreach(KeyValuePair<int, Students> entry in studentList){
//			s = entry.Value;
//			Console.WriteLine("Student name: " + s.getName() + ", Student ID: " + s.getID() + ", Fees Owed: " + s.getNum() + ", Average: " + s.getGrade()    );
//			 }
