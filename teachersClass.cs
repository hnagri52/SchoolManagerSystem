/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/4/2019
 * Time: 6:38 PM
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
	public class Teachers
	{
		private string name;
		private int employeeID;
		private double salary;
		private int VcnDays;
		
		public Teachers()
		{
			this.name = "";
			this.employeeID = 0;
			this.salary = 0.00;
			this.VcnDays = 0;
		}
		public Teachers (string name, int ID, double pay, int days){
			this.name = name;
			this.employeeID = ID;
			this.salary = pay;
			this.VcnDays = days;
		}
		
		public void setName(string name){
			this.name = name;
		}
		public string getName(){
			return this.name;
		}
		public void setEmployeeID(int ID){
			this.employeeID = ID;
		}
		public int getEmployeeID(){
			return this.employeeID;
		}
		public void setSalary(double pay){
			this.salary = pay;
		}
		public double getSalary (){
			return this.salary;
		}
		public void setVcnDays(int ID){
			this.VcnDays = ID;
		}
		public int getVcnDays(){
			return this.VcnDays;
		}
		
		public void DemandRaise(){
			
			Random r = new Random();
		
			if ( (r.Next(0,100)) < 10){ 
				Console.WriteLine("Your old salary was: " + this.salary);
				this.salary+=1000;
				Console.WriteLine("Congrats on the $1000 raise!\n\nYour new salary is: " + this.salary);
			}
			else{
				Console.WriteLine("Sorry, your request has been denied. Keep up the great work ethic though!");
			}
			
		}
		public void takeVcn(){
			
			string temp;
			int days;
			
			
			Console.WriteLine("Please enter the amount of days you would like to take off: ");
			temp = Console.ReadLine();
			days = Convert.ToInt32(temp);
			
			if (days > this.VcnDays)
				Console.WriteLine("Sorry, you do not have enough vacation days. Request Denied. ");
			else{
				
				Console.WriteLine("You had " + this.VcnDays + " vacation days.");
				this.VcnDays-= days;
				
				Console.WriteLine("You now have " + this.VcnDays + " vacation days left. ");
				
				
				Console.WriteLine("Your request has been accepted! Have fun on vacation!");
			
			}
			
		}
		
		
		//method and variables: vacation days, take vacation, etc
		//add variable: on vacation ??
		//
		
	}
}


				
			/*Teachers Sabihah = new Teachers("Sabihah Khan Nagri", 1, 80000.90);
			Teachers Hussein = new Teachers ("Hussein Nagri", 2, 100000);
			Teachers Bea = new Teachers ("Bea Persaud", 3, 50000);
			
			Students sChild = new Students(1, 15000, "Ben Frank", 87.45);
			Students hChild = new Students(2, 20000, "Job Bob", 95.3);
			Students bChild = new Students(3, 25000, "Peter Ma", 67.53);
			Students muneb = new Students();
																		//List <Teachers> teachersList = new ArrayList<>();
		
			//var list = SSS.getStudentList();
			//list.140ForEach(Console.WriteLine);
			
			//Console.WriteLine(SSS.getStudentList());
			
		
			teacherList.Add(Sabihah);
			teacherList.Add(Hussein);
			teacherList.Add(Bea);
																					//List <Students> studentsList = new ArrayList<>();
			//sChild.moneyPaying(345);
			//	SSS.addStudent(muneb);
			
			studentList.Add(sChild);
			studentList.Add(hChild);
			studentList.Add(bChild);
			*/
