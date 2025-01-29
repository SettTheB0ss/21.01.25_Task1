using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task12
{
    private double _t12;
    private double _y12;

    public Task12(double t12, double y12)
    {
        _t12 = t12;
        _y12 = y12;

    }

    public void R()
    {
        Console.WriteLine($"G={(Math.Sin(2*_t12 +1) + 0.3)/(Math.Log(_t12 + _y12 ))}");
    }
}
