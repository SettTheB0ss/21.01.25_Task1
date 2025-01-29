using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task25
{
    private double _c25;
    private double _t25;

    public Task25(double c25, double t25)
    {
        _c25 = c25;
        _t25 = t25;

    }

    public void L()
    {
        Console.WriteLine($"G={Math.Cos(_c25 )+ (3*Math.Pow(_t25,2)+4)/ (Math.Sqrt(_c25 +_t25 ))}");
    }
}
