using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task9
{
    private double _w9;
    private double _y9;

    public Task9(double w9, double y9)
    {
        _w9 = w9;
        _y9 = y9;

    }

    public void V()
    {
        Console.WriteLine($"G={(Math.Pow(_y9 +2*_w9,2))/(Math.Log(_y9+0.75))}");
    }
}
