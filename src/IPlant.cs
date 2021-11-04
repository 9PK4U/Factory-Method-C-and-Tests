using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public interface IPlant
    {
        string Name { get; }
        UInt32 Height { get; }
        string ToString();
    }
}
