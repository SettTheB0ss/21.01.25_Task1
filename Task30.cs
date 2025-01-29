using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task30
{
    private double _p30;
    private double _y30;

    public Task30(double y30, double p30)
    {
        _p30 = p30;
        _y30 = y30;

    }

    public void Z()
    {
        Console.WriteLine($"G={((3*Math.Pow(_y30,2)) + Math.Sqrt(_y30+1))/(Math.Log(_p30+_y30)+Math.Pow(Math.E,2))}");
    }
}
