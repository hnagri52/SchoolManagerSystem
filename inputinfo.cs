/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/13/2019
 * Time: 1:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SchoolManager
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public static class inputinfo
	{
		private static string tempo;
		
		public static void getAllInfoTeach(Dictionary <int, Teachers> teacherlist, int teacherAmount)
		{
			
			for (int i = 0 ; i < teacherAmount ; i++){
				string teacherName;
				int teachID;
				double salary;
				int vcn;
				
				Console.WriteLine ("Please enter the information regarding teacher " + (i+1) + ":");
				Console.WriteLine ("Please enter the name of the teacher: ");
				teacherName = Console.ReadLine();
				Console.WriteLine("Please enter the ID of the teacher:");
				tempo = Console.ReadLine();
				teachID = Convert.ToInt32(tempo);
				Console.WriteLine("Please enter the pay of the teacher: ");
				tempo = Console.ReadLine();
				salary = Convert.ToDouble(tempo);
				Console.WriteLine("Please enter the amount of vacation days the teacher has: ");
				tempo = Console.ReadLine();
				vcn = Convert.ToInt32(tempo);
				
				Teachers teacher = new Teachers(teacherName, teachID, salary, vcn); //how do I allow the teacherName to be the object for that teacher\
				teacherlist.Add(teachID, teacher);
			}
		}
		public static void getAllInfoStud(Dictionary <int, Students> studentList, int studentAmount){
			
			for (int i = 0 ; i < studentAmount ; i++){
				string studentName;
				int studentID;
				int feesOwed;
				double studentGrade;
				
				
				Console.WriteLine ("Please enter the information regarding student " + (i+1) + ":");
				Console.WriteLine ("Please enter the name of the student: ");
				studentName = Console.ReadLine();
				Console.WriteLine("Please enter the ID of the student:");
				tempo = Console.ReadLine();
				studentID = Convert.ToInt32(tempo);
				Console.WriteLine("Please enter the fees owed by the student: ");
				tempo = Console.ReadLine();
				feesOwed = Convert.ToInt32(tempo);
				do{
				Console.WriteLine("Please enter the student's average: ");
				tempo = Console.ReadLine();
				studentGrade = Convert.ToDouble(tempo);
				}while (studentGrade>100 || studentGrade < 0);
			
				
				Students child = new Students(studentID, feesOwed, studentName, studentGrade); //how do I allow the teacherName to be the object for that teacher
				studentList.Add(studentID, child);
				
			}

			
			
		}
	}
}


//			for (int i = 0 ; i < teacherAmount ; i++){
//				string teacherName;
//				int teachID;
//				double salary;
//				
//				Console.WriteLine ("Please enter the information regarding teacher " + (i+1) + ":");
//				Console.WriteLine ("Please enter the name of the teacher: ");
//				teacherName = Console.ReadLine();
//				Console.WriteLine("Please enter the ID of the teacher:");
//				temp = Console.ReadLine();
//				teachID = Convert.ToInt32(temp);
//				Console.WriteLine("Please enter the pay of the teacher: ");
//				temp = Console.ReadLine();
//				salary = Convert.ToDouble(temp);
//				
//				Teachers teacher = new Teachers(teacherName, teachID, salary); //how do I allow the teacherName to be the object for that teacher\
//				teacherList.Add(teachID, teacher);
//			}
			


			
//			for (int i = 0 ; i < studentAmount ; i++){
//				string studentName;
//				int studentID;
//				int feesOwed;
//				double studentGrade;
//				
//				
//				Console.WriteLine ("Please enter the information regarding student " + (i+1) + ":");
//				Console.WriteLine ("Please enter the name of the student: ");
//				studentName = Console.ReadLine();
//				Console.WriteLine("Please enter the ID of the student:");
//				temp = Console.ReadLine();
//				studentID = Convert.ToInt32(temp);
//				Console.WriteLine("Please enter the fees owed by the student: ");
//				temp = Console.ReadLine();
//				feesOwed = Convert.ToInt32(temp);
//				do{
//				Console.WriteLine("Please enter the student's average: ");
//				temp = Console.ReadLine();
//				studentGrade = Convert.ToDouble(temp);
//				}while (studentGrade>100 || studentGrade < 0);
//			
//				
//				Students child = new Students(studentID, feesOwed, studentName, studentGrade); //how do I allow the teacherName to be the object for that teacher
//				studentList.Add(studentID, child);
//				
//			}
