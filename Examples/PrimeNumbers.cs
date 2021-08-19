using System;
					
public static class Program
{
	public static void Main()
	{ 
		long number = 111;
		
		Console.WriteLine(getPrimeNumbers(number));
	}  
	
	public static string getPrimeNumbers(long number)
	{
		string primeNumbers = String.Empty;
		
		for(long i = 2; i <= number; i++) 
		{
			if(isPrimeNumber(i))
			{
				result += i + " ";
			}
		}
		
		return primeNumbers;
	}
	
	public static bool isPrimeNumber(long number)
	{
		for(long testNumber = 2; testNumber < number; testNumber++)
		{
			if (number % testNumber == 0)
			{
				return false;
			}
		}	

		return true;
	}
}