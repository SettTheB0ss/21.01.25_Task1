using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task16
{
    private double _r16;
    private double _y16;

    public Task16(double r16, double y16)
    {
        _r16 = r16;
        _y16 = y16;

    }

    public void W()
    {
        Console.WriteLine($"G={(Math.Pow(_r16,3)*2 + Math.Log(_r16))/(Math.Pow(Math.E,_r16+_y16 )+7.2*Math.Sin(_r16))}");
    }
}
