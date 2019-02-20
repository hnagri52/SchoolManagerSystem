/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/4/2019
 * Time: 2:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace SchoolManager
{
	class SchoolMain
	{
		public static void Main(string[] args)
		{
			string go;
			string schoolName = "";
			string temp;
			int change = 0;
			int teacherAmount=0;
			int studentAmount;
			List <School> schoolList = new List<School>();
			
			Console.WriteLine("Welcome to the school managing system. Please enter the school name: ");
			
			schoolName = Console.ReadLine();
			
			Console.WriteLine("your school name is: " + schoolName + "\nHow many teachers are in your school? ");
			temp = Console.ReadLine();
			teacherAmount = Convert.ToInt32(temp);
						
			Dictionary <int,Teachers> teacherList = new Dictionary <int,Teachers>() ;
				
			inputinfo.getAllInfoTeach(teacherList, teacherAmount);

						
			Console.WriteLine("How many students are in your school? ");
			temp = Console.ReadLine();
			studentAmount = Convert.ToInt32(temp);
			
			
			Dictionary <int, Students> studentList = new Dictionary<int, Students>();
			
			inputinfo.getAllInfoStud(studentList, studentAmount);

				
			School theSchool = new School(teacherList, studentList); //ask help how to make the schoolName object when receiving input
			schoolList.Add(theSchool);
		

		//	School SSS = new School(teacherList, studentList);

	
				printInfo.printALLInfo(teacherList, studentList);
				do{
			Console.WriteLine("\n\n What would you like to make an adjustment to:\n1. A teacher?\n2. A student?\n3. Money Made?\n4. Money Spent?\n");
			temp = Console.ReadLine();
			change = Convert.ToInt32(temp);
			
			switch (change){
					case 1: {
						theSchool.teacherController(teacherList);
						break;
					}
					case 2: {
						theSchool.studentController(studentList);
						break;
					}
					case 3:{
						Console.WriteLine("Would you like to \n1.See the School's income?\n2. Add revenue?");
						temp = Console.ReadLine();
						if (temp == "1")
							theSchool.getTME();
						else{
							int money;
							Console.WriteLine("Enter the amount of money earned: ");
							temp = Console.ReadLine();
							money = Convert.ToInt32(temp);
							theSchool.updateTME(money);
							}
						break;
					}
					case 4:{
						Console.WriteLine("Would you like to \n1.See the School's expenses?\n2. Pay expenses?");
						temp = Console.ReadLine();
						if (temp == "1")
							theSchool.getTMS();
						else{
							int money;
							Console.WriteLine("Enter the amount of money spent: ");
							temp = Console.ReadLine();
							money = Convert.ToInt32(temp);
							theSchool.UpdateTMS(money);
							}
						break;
					}
						
				
			}
			
			Console.WriteLine("Would you like to make any other changes?" );
			go = Console.ReadLine();
			
		
	}while(go == "yes" || go == "Yes" || go == "y");
				
			Console.ReadKey(true);

		}
	}
}

