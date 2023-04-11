using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11Features;

public struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        //Y = y; Normally (up to c# 11) you would need to assign the value to all fields of a struct, but now default value is assigned behind the scenes. 
    }
}
