using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task24
{
    private double _k24;
    private double _y24;

    public Task24(double k24, double y24)
    {
        _k24 = k24;
        _y24 = y24;

    }

    public void U()
    {
        Console.WriteLine($"G={(Math.Log(2*_k24+4.3))/(Math.Pow(Math.E,_k24 + _y24 ))}");
    }
}