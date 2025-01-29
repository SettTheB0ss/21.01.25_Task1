using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task6
{
    private double _i6;
    private double _y6;

    public Task6(double i6, double y6)
    {
        _i6 = i6;
        _y6 = y6;
        
    }

    public void L6()
    {
        Console.WriteLine($"G={(0.81*Math.Cos(_i6))/(Math.Log(_y6)+2*Math.Pow(_i6,3))}");
    }
}
