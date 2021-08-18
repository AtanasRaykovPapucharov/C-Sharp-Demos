# Binary To Decimal

```cs
double BinaryToDecimal(string binary)
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
```

# Decimal To Binary

```cs
string DecimalToBinary(int number)
{
    int remainder;
    string result = string.Empty;
    
    while (number > 0)
    {
        remainder = number % 2;
        number /= 2;
        result = remainder.ToString() + result;
    }
    
    return result;
}
```

# Quadratic Equation

```cs
double?[] QuadraticEquation(double a, double b, double c) 
{
    double? x1 = 0;
    double? x2 = 0;
    
    double det = b*b - 4*a*c;
    
    // Console.WriteLine("Det = " + det);
    
    if(det < 0) 
    {
        x1 = null;
        x2 = null;
    } 
    else if(det == 0) 
    {
        x1 = -b / 2;
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
```