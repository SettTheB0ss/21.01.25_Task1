using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task10
{
    private double _t10;
    private double _y10;

    public Task10(double t10, double y10)
    {
        _t10 = t10;
        _y10 = y10;

    }

    public void Z()
    {
        Console.WriteLine($"G={(2*_t10+_y10*Math.Cos(_t10))/(Math.Sqrt(_y10+4.831))}");
    }
}
