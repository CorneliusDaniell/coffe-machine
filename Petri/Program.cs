using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffePetriNet machine = new CoffePetriNet();
            machine.Start();
        }
    }
}

		



/*
	public void PrintMenu()
	{
		Console.WriteLine("Current coins: ");
		Console.WriteLine(GetCurrentState());
		Console.WriteLine("1. Insert 5 coins ");
		Console.WriteLine("2. Insert 10 coins ");
		Console.WriteLine("3. Buy expresso (15 coins) ");
		Console.WriteLine("4. Buy cappuccino (20 coins) ");
		Console.WriteLine("0. Exit ");
	}*/
