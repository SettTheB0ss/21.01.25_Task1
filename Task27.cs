using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task27
{
    private double _p27;
    private double _y27;

    public Task27(double p27, double y27)
    {
        _p27 = p27;
        _y27 = y27;

    }

    public void Z()
    {
        Console.WriteLine($"G={Math.Sin(2 * _p27) / Math.Log((2 * _y27 + _p27))}");
    }
}
