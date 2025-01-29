using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task4
{
    private double _w4;
    private double _y4;

    public Task4(double w4, double y4)
    {
        _w4 = w4;
        _y4 = y4;
    }

    public void G4()
    {
        Console.WriteLine($"G={(9.33 * Math.Pow(_w4, 3) + Math.Sqrt(_w4)) / (Math.Log(_y4 + 3.5) + Math.Sqrt(_y4))}");
    }
}
