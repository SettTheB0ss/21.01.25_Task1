using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task19
{
    private double _q19;
    private double _y19;

    public Task19(double q19, double y19)
    {
        _q19 = q19;
        _y19 = y19;

    }

    public void E()
    {
        Console.WriteLine($"G={(Math.Log(0.7*_y19 + _q19*2))/Math.Sqrt(3*Math.Pow(_y19,2) + 0.5*_y19 +4)}");
    }
}
