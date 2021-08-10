using System;
					
public static class Program
{
	public static void Main()
	{
		double?[] result = QuadraticEquation(1, -4, 4); 
		
		if(result[0] != null) 
		{
			if(result[1] != null) 
			{
				Console.WriteLine("Roots are: x1 = {0} , x2 = {1}", result[0],result[1]);
			}
			else
			{
				Console.WriteLine("Roots are: x1 =  x2 = {0}", result[0]);
			}
		}
		else
		{
			Console.WriteLine("No Real Roots!");
		}
	}  
	
	static double?[] QuadraticEquation(int a, int b, int c) 
	{
		double? x1 = 0;
		double? x2 = 0;
		
		int det = b*b - 4*a*c;
		
		Console.WriteLine("Det = " + det);
		
		if(det < 0) 
		{
			x1 = null;
			x2 = null;
		} 
		else if(det == 0) 
		{
			x1 = b*b / 2;
			x2 = null;
		}
		else 
		{
			x1 = (-b + Math.Sqrt(det)) / 2;
			x2 = (-b - Math.Sqrt(det)) / 2;
		}
		
		double?[] result = { x1, x2 };
		
		return result ;
	}
}