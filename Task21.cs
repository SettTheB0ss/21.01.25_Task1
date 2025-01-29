using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task21
{
    private double _d21;
    private double _y21;
    private double _k21;

    public Task21(double t21, double y21, double k21)
    {
        _d21 = t21;
        _y21 = y21;
        _k21 = k21;

    }

    public void K()
    {
        Console.WriteLine($"G={(Math.Sqrt(_k21 + 2.6*Math.Sin(_k21 )))/(_k21 - Math.Pow(_d21,3))}");
    }
}
