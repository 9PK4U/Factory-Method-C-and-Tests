using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3.Plants
{
    public class Tree : IPlant
    {
        public string Name { get; }

        public UInt32 Height { get; }
        public UInt32 Age { get; }

        public override string ToString()
        {
            return $"Type:Tree\tName:{this.Name}\tHeight:{this.Height}\tAge:{this.Age}";
        }
        public Tree(string name, UInt32 height, UInt32 age)
        {
            Name = name;
            Height = height;
            Age = age;
        }
    }
}
