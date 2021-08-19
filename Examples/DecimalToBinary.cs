using System;
					
public static class Program
{
	public static void Main()
	{
		Console.Write("Decimal: ");
		int decimalNumber = int.Parse(Console.ReadLine());
		Console.WriteLine(DecimalToBinary(decimalNumber));
	}  
	
	static string DecimalToBinary(int number)
	{
		int remainder;
		string result = string.Empty;
		
		while (number >= 0)
		{
			remainder = number % 2;
			number /= 2;
			result = remainder.ToString() + result;
		}
		
		return result;
	}
}