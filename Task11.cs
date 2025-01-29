using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task11
{
    private double _n11;
    private double _y11;

    public Task11(double n11, double y11)
    {
        _n11 = n11;
        _y11 = n11;

    }

    public void D()
    {
        Console.WriteLine($"G={Math.Pow(_y11,2)+ (0.5*_n11 + 4.8)/(Math.Sin(_y11))}");
    }
}
