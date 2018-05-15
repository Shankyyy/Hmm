/*
 * Created by SharpDevelop.
 * User: student
 * Date: 14-02-2018
 * Time: 10:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Array
{
	class Program
	{
		public static void Main(string[] args)
		{   
			Console.WriteLine("enter the size of the array ");
			int s = int.Parse(Console.ReadLine());
			int[] arr = new int[s];
			
			Console.WriteLine("enter the array num");
			for (int i = 0; i < s; i++)
			{
				Console.Write("Array[{0}] = ",i);
				arr[i] = int.Parse(Console.ReadLine());
				
			}          
			int small1 ;
			int small2 ;
			if (arr[0] < arr[1]) {
				 small1 = arr[0];
				 small2 = arr[1];
			}else{
			      small1 = arr[1];
				  small2 = arr[0];
			}
			for (int i = 2; i < s; i++) {
				if (arr[i] < small1 ) {
					small2 = small1;
					small1 = arr[i];
				}
				else if (arr[i] < small2 ) {
					small2 = arr[i];
				}
			}
				Console.WriteLine(" 2 Smallest number is {0}",small2);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}