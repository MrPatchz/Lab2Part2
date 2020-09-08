/// Chapter No. 2		Exercise No. 2
/// File Name: Lab2Part2.cs
/// @author: Jacques Zwielich 
/// Date:  September 07, 2020
///
/// Problem Statement: Determine how many gumballs and candybars you can afford with tickets
/// 
/// 
/// Overall Plan:
/// 1) Initialize price of gumballs, tickets, and candybars
/// 2) Print how many candybars you can afford
/// 3) print how many gumballs you can afford
/// 4) print how many tickets you have left
/// 

using System;
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Cost of a candybar is 10, and cost of a gumball is 3. You have 45 tickets.");
			int tickets = 45;
			int gumball, candybar;
			gumball = 3;
			candybar = 10;
			Console.WriteLine("You can afford " + tickets / candybar + " candybars");
			tickets = tickets % candybar;
			Console.WriteLine("After, you can afford " + tickets / gumball + " gumballs");
			tickets = tickets % gumball;
			Console.WriteLine("You have " + tickets + " Tickets Leftover");
			Console.ReadLine();
		}

	}
