using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task28
{
    private double _v28;
    private double _y28;

    public Task28(double v28, double y28)
    {
        _v28 = v28;
        _y28 = y28;

    }

    public void Z()
    {
        Console.WriteLine($"G={(000.4*_v28 + Math.Pow(Math.E,2*_y28 ))/Math.Pow(Math.E,_y28 / 2)}");
    }
}
