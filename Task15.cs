using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task15
{
    private double _j15;
    private double _y15;

    public Task15(double j15, double y15)
    {
        _j15 = j15;
        _y15 = y15;

    }

    public void F()
    {
        Console.WriteLine($"G={(2*Math.Sin(0.354*_y15 + 1))/(Math.Log(_y15 + _j15 * 2))}");
    }
}
