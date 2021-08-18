using System;
					
public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Fibonacci(11));
    }  

    static string Fibonacci(int n)  
    {  
        long firstNumber = 0;
        long secondNumber = 1;
        long result = 0; 
        string series = "0, 1";

        if (n < 0) return null; 
        else if (n == 0) return n.ToString(); 
        else if (n == 1) return series;


        for (int i = 2; i <= n; i++)  
        {  
            result = firstNumber + secondNumber;  
            firstNumber = secondNumber;  
            secondNumber = result;  
            series = series + ", " + result.ToString();
        }  

        return series;  
    } 
}