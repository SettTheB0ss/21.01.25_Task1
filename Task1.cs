using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task1
{
    private double _e1;
    private double _y1;
    private double _f1;

    public Task1 (double e1, double y1, double f1)
    {
        _e1 = e1;
        _y1 = y1;
        _f1 = f1;
    }

    public void G1()
    {
        Console.WriteLine($"G={(Math.Pow(_e1, 2* _y1) + Math.Sin(_f1))/(Math.Log(3.8*_y1 +_f1))}");
    }
}
