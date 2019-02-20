/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/13/2019
 * Time: 3:18 PM
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
	public static class teacherControllers
	{
		private static string tempst;
		private static int optionst;
		private static int tFind;
		
		public static void controlTeachers(Dictionary <int, Teachers> tlist)
		{
			Console.WriteLine("What would you like to do with the teachers? \n1. Add a new teacher?\n2. View the teacher's salary?\n3. " +
			                  "Ask for a raise?\n4. Take days off?");
			tempst = Console.ReadLine();
			optionst = Convert.ToInt32(tempst);
			Console.Write(optionst);
			
			
			switch (optionst) {
			
					case 1: {
						string teacherName;
						int teachID;
						double salary;
						int vcn;
						
						Console.WriteLine ("Please enter the information regarding teacher: ");
						Console.WriteLine ("Please enter the name of the teacher: ");
						teacherName = Console.ReadLine();
						Console.WriteLine("Please enter the ID of the teacher:");
						tempst = Console.ReadLine();
						teachID = Convert.ToInt32(tempst);
						Console.WriteLine("Please enter the pay of the teacher: ");
						tempst = Console.ReadLine();
						salary = Convert.ToDouble(tempst);
						Console.WriteLine("Please enter the amount of vacation days the teacher has: ");
						tempst = Console.ReadLine();
						vcn = Convert.ToInt32(tempst);
						
						Teachers teacher = new Teachers(teacherName, teachID, salary, vcn); //how do I allow the teacherName to be the object for that teacher\
						tlist.Add(teachID, teacher);
					
						break;
					}
					
			
					case 2: {
					
						Console.WriteLine("Please enter the ID of the teacher who's data you would like to modify: ");
						tempst = Console.ReadLine();
					    tFind = Convert.ToInt32(tempst);
					  	
					    if (tlist.ContainsKey(tFind) ){
					    	Console.Write("The Teacher's salary is: ");
					    	Console.WriteLine(tlist[tFind].getSalary() );
					    }
						
						break;
					}
					
					case 3: {
						
						
						Console.WriteLine("Please enter the ID of the teacher who's data you would like to modify: ");
						tempst = Console.ReadLine();
					    tFind = Convert.ToInt32(tempst);
					    
					    if (tlist.ContainsKey(tFind) ){
					    		    						    	
					   	 	tlist[tFind].DemandRaise();
					   }
						
						break;
					}
					
					case 4:{
					
						Console.WriteLine("Please enter the ID of the teacher who's data you would like to modify: ");
						tempst = Console.ReadLine();
					    tFind = Convert.ToInt32(tempst);
					    
					    
					    if (tlist.ContainsKey(tFind) ){
					      	tlist[tFind].takeVcn();
					   }
						
						break;
					
					
					}
						
			}
		}
	}
}
