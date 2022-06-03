
using System;


class prime
{
	static bool isPrime(int num)
	{


		if (num % 2 == 0)
		{
			return false;
		}
		else
		{
			return true;
		}
	}

	static void Main()
	{
		int x = Int32.Parse(Console.ReadLine());
		if (isPrime(x))
		{
			Console.WriteLine("true");
		}
		else
		{
			Console.WriteLine("false");
		}
		Thread.Sleep(20000);
	}
}
