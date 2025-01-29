using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task5
{
    private double _a5;
    private double _y5;
    private double _t5;

    public Task5(double a5, double y5, double t5)
    {
        _a5 = a5;
        _y5 = y5;
        _t5 = t5;
    }

    public void D5()
    {
        Console.WriteLine($"G={(7.8*Math.Pow(_a5,2) + 3.52*_t5)/(Math.Log(_a5 + 2*_y5) + Math.Pow(Math.E,_y5))}");
    }
}