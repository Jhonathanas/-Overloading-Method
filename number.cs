using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Numbers
{
    public int FindMinimum(int number1, int number2)
    {
       if (a < b)
                min = a;
            else
                min = b;      
    }
    public int FindMinimum(int number1, number2, float number3)
    {
        if (a < b)
                min = a;
            else
                min = b;
        if (a < c)
                min = a;
            else
                min = c;
        if (b < c)
                min = b;
            else
                min = c;
    }
    public int FindMaximum(int number1, number2)
    {
        if (a > b)
                max = a;
            else
                max = b;
    }
    public int FindMaximum(int number1, number2, float number3)
    {
        if (a > b)
                max = a;
            else
                max = b;
         if (a < c)
                max = a;
            else
                max = c;
        if (b < c)
                max = b;
            else
                max = c;
    }
}