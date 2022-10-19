using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				int plus = 5-i;
				string valueplus = new string('+', plus);
				Console.Write(valueplus);
				for (int k = 1; k <=i; k++)
					{
					Console.Write(i);
					}
			Console.WriteLine();		
			}
		
		}
		
	}
}
