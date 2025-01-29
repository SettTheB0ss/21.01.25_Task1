using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task22
{
    private double _t22;
    private double _y22;

    public Task22( double y22, double t22)
    {
        _t22 = t22;
        _y22 = y22;

    }

    public void S()
    {
        Console.WriteLine($"G={(4.351*Math.Pow(_y22,2) + 2*_t22*Math.Log(_t22))/ Math.Sqrt(Math.Cos(2*_y22 ) + 4.351)}");
    }
}
