using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task18
{
    private double _k18;
    private double _y18;

    public Task18(double k18, double y18)
    {
        _k18 = k18;
        _y18 = y18;

    }

    public void R()
    {
        Console.WriteLine($"G={(Math.Sqrt(Math.Pow(Math.Sin(_y18),2)) + 6.835)/(Math.Log(_y18+_k18) +3*Math.Pow(_y18,2))}");
    }
}
