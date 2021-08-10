using System;
					
public static class Program
{
	public static void Main()
	{
		Console.Write("Binary: ");
		Console.WriteLine("Decimal:  {0}", BinaryToDecimal(Console.ReadLine()));
	}  
	
	static double BinaryToDecimal(string binary)
	{
		int n = 0;
		double result = 0;
		
		for(int i = binary.Length - 1; i >= 0; i--) 
		{
			if(binary[i] != '0')
			{
				result += Math.Pow(2, n);
			}
			
			n++;
		}
		
		return result;
	}
}