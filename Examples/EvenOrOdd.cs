using System;
					
public static class Program
{
	public static void Main()
	{ 
		int number = 111;
		
		Console.WriteLine(isOdd(number));
		Console.WriteLine(isEven(number));
	}  
	
	public static bool isOdd(long number)
	{
		if(number % 2 == 1)
		{
			return true;
		}
		
		return false;
	}
	
	public static bool isEven(long number)
	{
		if(number % 2 == 0)
		{
			return true;
		}
		
		return false;
	}
}