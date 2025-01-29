using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task20
{
    private double _t20;
    private double _y20;
    private double _l20;

    public Task20(double t20, double y20, double l20)
    {
        _t20 = t20;
        _y20 = y20;
        _l20 = l20;

    }

    public void K()
    {
        Console.WriteLine($"G={(Math.Pow(_t20,2)*2 +3*_l20+7.2)}");
    }
}