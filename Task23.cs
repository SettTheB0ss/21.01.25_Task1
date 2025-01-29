using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task23
{
    private double _d23;
    private double _y23;

    public Task23(double y23, double d23)
    {
        _d23 = d23;
        _y23 = y23;

    }

    public void R()
    {
        Console.WriteLine($"G={((Math.Pow(Math.Sin(_y23), 2) + 0.4 * _d23)) / (Math.E + Math.Log(_d23))}");
    }
}
