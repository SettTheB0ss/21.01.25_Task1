using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task17
{
    private double _k18;
    private double _y18;

    public Task17(double k18, double y18)
    {
        _k18 = k18;
        _y18 = y18;

    }

    public void H()
    {
        Console.WriteLine($"G={(Math.Pow(_y18,2)-0.8*_y18 + Math.Sqrt(_y18))}");
    }
}