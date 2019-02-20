/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/13/2019
 * Time: 2:02 PM
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
	public static class studentControllers
	{
		private static string temps;
		private static int options;
		private static int studentFind;
		
		public static void controlStudents(Dictionary <int, Students> slist)
		{
			
			
			Console.WriteLine("What would you like to do with the students? \n1. Add a new student?\n2. View the student's grade?\n3. " +
			                  "Add a new test mark?\n4. Pay fees?");
			temps = Console.ReadLine();
			options = Convert.ToInt32(temps);
			Console.Write(options);
			
			switch (options){
					case 1:{
						string studentName;
						int studentID;
						int feesOwed;
						double studentGrade;

						
						Console.WriteLine ("Please enter the information regarding student: ");
						Console.WriteLine ("Please enter the name of the student: ");
						studentName = Console.ReadLine();
						Console.WriteLine("Please enter the ID of the student:");
						temps = Console.ReadLine();
						studentID = Convert.ToInt32(temps);
						Console.WriteLine("Please enter the fees owed by the student: ");
						temps = Console.ReadLine();
						feesOwed = Convert.ToInt32(temps);
						do{
							Console.WriteLine("Please enter the student's average: ");
							temps = Console.ReadLine();
							studentGrade = Convert.ToDouble(temps);
						}while (studentGrade>100 || studentGrade < 0);
						
						Students child = new Students(studentID, feesOwed, studentName, studentGrade); //how do I allow the teacherName to be the object for that teacher
						slist.Add(studentID, child);
						break;
						
			}
					case 2:
						{
						Console.WriteLine("Please enter the ID of the student who's data you would like to modify: ");
						temps = Console.ReadLine();
					    studentFind = Convert.ToInt32(temps);
					  	
					    if (slist.ContainsKey(studentFind) ){
					    	Console.Write("The Student's grade is: ");
					    	Console.WriteLine(slist[studentFind].getGrade() );
					    }
						
						break;
						
					}
					
					case 3:{
						Console.WriteLine("Please enter the ID of the student who's data you would like to modify: ");
						temps = Console.ReadLine();
					    studentFind = Convert.ToInt32(temps);
					    
					    if (slist.ContainsKey(studentFind) ){
					    	int mark = 0;
					    	Console.WriteLine("Please enter the new test grade (note: new added tests are weighted 50% of the current mark): ");
					    	temps = Console.ReadLine();
					    	mark = Convert.ToInt32(temps);
					    	
					    	slist[studentFind].newTest(mark);
					        }
					    break;
					}
					
					case 4:{
						
						Console.WriteLine("Please enter the ID of the student who's data you would like to modify: ");
						temps = Console.ReadLine();
					    studentFind = Convert.ToInt32(temps);
					    
					    if (slist.ContainsKey(studentFind) ){
					    	int pay = 0;
							Console.WriteLine("Please enter the amount being paid (integer only): ");
					    	temps = Console.ReadLine();
					    	pay = Convert.ToInt32(temps);
					    	
					    						    	
					    	slist[studentFind].moneyPaying(pay);
					    	
					        }
						
						
					    break;
					}
	
			
			
			}
		
		
		
		
			
			
			
			
		}
	}
}

//			Console.WriteLine("What would you like to do with the students? \n1. Add a new student?\n2. View the student's grade?\n3. " +
//			                  "Add a new test mark?\n4. Pay fees?");
//			temp = Console.ReadLine();
//			option = Convert.ToInt32(temp);
//			Console.Write(option);
//			
//			switch (option){
//					case 1:{
//						string studentName;
//						int studentID;
//						int feesOwed;
//						double studentGrade;
//
//						
//						Console.WriteLine ("Please enter the information regarding student: ");
//						Console.WriteLine ("Please enter the name of the student: ");
//						studentName = Console.ReadLine();
//						Console.WriteLine("Please enter the ID of the student:");
//						temp = Console.ReadLine();
//						studentID = Convert.ToInt32(temp);
//						Console.WriteLine("Please enter the fees owed by the student: ");
//						temp = Console.ReadLine();
//						feesOwed = Convert.ToInt32(temp);
//						do{
//							Console.WriteLine("Please enter the student's average: ");
//							temp = Console.ReadLine();
//							studentGrade = Convert.ToDouble(temp);
//						}while (studentGrade>100 || studentGrade < 0);
//						
//						Students child = new Students(studentID, feesOwed, studentName, studentGrade); //how do I allow the teacherName to be the object for that teacher
//						slist.Add(studentID, child);
//						break;
//						
//			}
//					case 2:
//						{
//						Console.WriteLine("Please enter the ID of the student who's data you would like to modify: ");
//						temp = Console.ReadLine();
//					    studentFind = Convert.ToInt32(temp);
//					  	
//					    if (slist.ContainsKey(studentFind) ){
//					    	Console.Write("The Student's grade is: ");
//					    	Console.WriteLine(slist[studentFind].getGrade() );
//					    }
//						
//						break;
//						
//					}
//	
//			
//			
//			}
//		
		
		
		
		
