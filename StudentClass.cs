/*
 * Created by SharpDevelop.
 * User: hnagri
 * Date: 2/4/2019
 * Time: 2:36 PM
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
	public class Students
	{
		private int studentID;
		private int feesOwed;
		private string studentName;
		private double studentGrade;
		private int feesPaid;
		
		public Students()
		{
			this.studentID = 0;
			this.feesOwed = 100000;
			this.studentName = "";
			this.studentGrade = 0.00;
			this.feesPaid = 0;
		}
		
		public Students(int ID, int amount, string name, double grade){
			
			this.studentID = ID;
			this.feesOwed = amount;
			this.studentName = name;
			this.studentGrade = grade;
			this.feesPaid = 0;
		}
		
		public int getNum (){
			return this.feesOwed;
		}
		
		public void setNum (int num){
			this.feesOwed = num;
		}
		
		public int getID (){
			return this.studentID;
		}
		
		public void setID (int ID){
			this.studentID = ID;
		}
		public string getName (){
			return this.studentName;
		}
		public void setName(string name){
			this.studentName = name;
		}
		public double getGrade(){
			return this.studentGrade;
		}
		public void setGrade (double mark ){
			this.studentGrade = mark;
		}
		
		public void moneyPaying (int amount){
			Console.WriteLine ("The amount he paid is: " + amount);
			this.feesOwed-= amount;
			this.feesPaid+= amount;
			Console.WriteLine ("The amount of money he has left to may is: " + this.feesOwed);
		}
		public void newTest(double testmark){
			this.studentGrade= (this.studentGrade+testmark)/2.0;
		}
		
	
	}
}
