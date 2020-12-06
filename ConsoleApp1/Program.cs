using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/// <summary>
	///  
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			string[] items = {"abc", "abcdefghijklm" };
			foreach (var item in items)
			{
				string msg = $"{item}\t{item.Length}";
				Console.WriteLine(msg);
			}

			Console.WriteLine("==================");

			int maxLen = items.Select(s => s.Length).Max();
			foreach (var item in items)
			{
				string msg = $"{item.PadRight(maxLen+1)}\t{item.Length,4}";
				Console.WriteLine(msg);
			}

		}
	}
}
