using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_21_01_25;
public class Task26
{
    private double _y26;
    private double _u26;

    public Task26(double u26, double y26)
    {
        _y26 = y26;
        _u26 = u26;

    }

    public void T()
    {
        Console.WriteLine($"G={Math.Sin(2*_u26)/Math.Log((2*_y26 + _u26))}");
    }
}
