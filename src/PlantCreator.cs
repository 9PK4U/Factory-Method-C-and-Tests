using System;
using System.Collections.Generic;
using System.Text;
using Lab_3.Plants;

namespace Lab_3
{
    public abstract class PlantCreator
    {
        public abstract string Type { get; }
        public abstract IPlant FactoryMethod(Dictionary<string,string> parameters);
        public virtual string CheckName(string name)
        {
            if (Char.IsLower(name[0]))
                throw new Exception("Incorrect name:" + name + ". First letter must be capital.");
            foreach (char ch in (name))
                if (Char.IsLetter(ch) == false && ch != '-')
                    throw new Exception("Incorrect name:" + name + ". Name must be only letters.");
           return name;
        }
        public virtual UInt32 CheckHeight(string value)
        {
            try
            {
                UInt32 height = Convert.ToUInt32(value);
                if (height == 0)
                    throw new Exception("Wrong value:" + value + " Parametr must be an integer greater then 0.");
                return height;
            }
            catch (Exception )
            {
                throw new Exception("Wrong value:" + value + ". Parametr must be an integer more then 0.");
            }
        }
    }
    public class TreeCreator : PlantCreator
    {
        public override string Type { get; }
        public override IPlant FactoryMethod(Dictionary<string, string> parameters)
        {
            string name = "";
            UInt32 height = 1;
            UInt32 age = 1;
            if (parameters.Count != 3)
                throw new Exception("Wrong count of purumeters.");
            foreach (var el in parameters)
            {
                switch (el.Key)
                {
                    case "Name":
                        name = base.CheckName(parameters["Name"]);
                        break;
                    case "Height":
                        height = base.CheckHeight(parameters["Height"]);
                        break;
                    case "Age":
                        age = base.CheckHeight(parameters["Age"]);
                        break;
                    default:
                        throw new Exception($"Unexpected parameter:{el.Key}.");
                }
            }
            return new Tree(name, height, age);
        }
        public TreeCreator()
        {
            Type = "Tree";
        }
    }
    public class ShrubCreator : PlantCreator
    {
        public override string Type { get; }
        public override IPlant FactoryMethod(Dictionary<string, string> parameters)
        {
            string name = "";
            UInt32 height = 1;
            UInt16 monthFlowering = 1;
            if (parameters.Count != 3)
                throw new Exception("Wrong count of purumeters.");
            foreach (var el in parameters)
            {
                switch (el.Key)
                {
                    case "Name":
                        name = base.CheckName(parameters["Name"]);
                        break;
                    case "Height":
                        height = base.CheckHeight(parameters["Height"]);
                        break;
                    case "Month Flowering":
                        try
                        {
                            monthFlowering = Convert.ToUInt16(parameters["Month Flowering"]);
                            if (monthFlowering > 12 && monthFlowering < 1)
                                throw new Exception("Wrong value:" + monthFlowering + ". Month must be an integer between 1 and 12.");
                        }
                        catch (Exception )
                        {
                            throw new Exception("Wrong value: " + parameters["Month Flowering"] + ". Month must be an integer between 1 and 12.");
                        }
                        break;
                    default:
                        throw new Exception($"Unexpected parameter:{el.Key}.");
                }
            }
            return new Shrub(name, height, monthFlowering);
        }
        public ShrubCreator()
        {
            Type = "Shrub";
        }
    }
    public class MushroomCreator : PlantCreator
    {
        public override string Type { get; }
        public override IPlant FactoryMethod(Dictionary<string, string> parameters)
        {
            string name = "";
            UInt32 height = 1;
            bool edible = false;
            if (parameters.Count != 3)
                throw new Exception("Wrong count of purumeters.");
            foreach (var el in parameters)
            {
                switch (el.Key)
                {
                    case "Name":
                        name = base.CheckName(parameters["Name"]);
                        break;
                    case "Height":
                        height = base.CheckHeight(parameters["Height"]);
                        break;
                    case "Edible":
                        if (parameters["Edible"] != "Y" && parameters["Edible"] != "N")
                            throw new Exception("Wrong value:" + parameters["Edible"] + " Use \"Y\" or \"N\".");
                        edible = parameters["Edible"] == "Y";
                        break;
                    default:
                        throw new Exception($"Unexpected parameter:{el.Key}.");
                }
            }
            return new Mushroom(name, height, edible);
        }
        public MushroomCreator()
        {
            Type = "Mushroom";
        }
    }
}
