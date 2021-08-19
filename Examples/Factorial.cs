using System;
using System.Numerics;
					
public static class Program
{
	public static void Main()
	{ 
		int number = 111;
		
		Console.WriteLine(factorial(number));
	}  
	
	public static BigInteger factorial(int number)
	{
		BigInteger result = 1;
		
		while(number > 0)
		{
			result *= number;
			number--;
		}
		
		return result;
	}
}