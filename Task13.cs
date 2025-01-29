using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task13
{
    private double _n13;
    private double _y13;

    public Task13(double n13, double y13)
    {
        _n13 = n13;
        _y13 = y13;

    }

    public void A()
    {
        Console.WriteLine($"G={(Math.Sin(2*_y13 + _n13))/(Math.Pow(Math.E,_n13) + _y13 )}");
    }
}