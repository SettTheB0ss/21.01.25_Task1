using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task14
{
    private double _n14;
    private double _y14;

    public Task14(double n14, double y14)
    {
        _n14 = n14;
        _y14 = y14;

    }

    public void P()
    {
        Console.WriteLine($"G={(Math.Pow(Math.E,_y14 + 2.5) + 7.1*Math.Pow(_n14,3))/(Math.Log(Math.Sqrt( _y14 + 0.04* _n14)))}");
    }
}
