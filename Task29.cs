using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task29
{
    private double _h29;
    private double _y29;

    public Task29(double h29, double y29)
    {
        _h29 = h29;
        _y29 = y29;

    }

    public void Z()
    {
        Console.WriteLine($"G={(0.355*_h29 - 4.355)/(Math.Pow(Math.E, _y29 + _h29 )+Math.Sqrt(Math.E*2.7))}");
    }
}
