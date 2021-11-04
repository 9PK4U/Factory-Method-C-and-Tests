using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3.Plants
{
    public class Mushroom : IPlant
    {
        public string Name { get; }

        public UInt32 Height { get; }
        public bool Edible { get; }

        public override string ToString()
        {
            return $"Type:Mushroom\tName:{this.Name}\tHeight:{this.Height}\tEdible:{this.Edible}";
        }
        public Mushroom(string name, UInt32 height, bool edible)
        {
            Name = name;
            Height = height;
            Edible = edible;
        }
    }
}
