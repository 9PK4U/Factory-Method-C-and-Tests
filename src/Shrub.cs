using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3.Plants
{
    public class Shrub : IPlant
    {
        public string Name { get; }

        public UInt32 Height { get; }
        public UInt16 MonthFlowering { get; }

        public override string ToString()
        {
            return $"Type:Shrub\tName:{this.Name}\tHeight:{this.Height}\tMonth flowering:{this.MonthFlowering}";
        }
        public Shrub(string name, UInt32 height, UInt16 monthFlowering)
        {
            Name = name;
            Height = height;
            MonthFlowering = monthFlowering;
        }
    }
}
