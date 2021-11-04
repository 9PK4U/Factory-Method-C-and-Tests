using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab3.Plants;
using Lab3;

namespace UnitTestsLab3
{
    [TestClass]
    public class MushroomCreatorTest
    {
        [TestMethod]
        public void CreateCurrentMushroom()
        {
            MushroomCreator c = new MushroomCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Mushroom-m");
            d.Add("Height", "123");
            d.Add("Edible", "Y");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateMushroomWithWrongValueName()
        {
            MushroomCreator c = new MushroomCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "mushroom");
            d.Add("Height", "123");
            d.Add("Edible", "Y");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateMushroomWithWrongValueHeight()
        {
            MushroomCreator c = new MushroomCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "mushroom");
            d.Add("Height", "-123");
            d.Add("Edible", "Y");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateMushroomWithWrongValueEdible()
        {
            MushroomCreator c = new MushroomCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Mushroom-m");
            d.Add("Height", "123");
            d.Add("Edible", "Yes");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateMushroom_ParametersCountMoreThanNeed()
        {
            MushroomCreator c = new MushroomCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Mushroom-m");
            d.Add("Height", "123");
            d.Add("Edible", "Y");
            d.Add("Color", "Black");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateMushroom_ParametersCountLessThanNeed()
        {
            MushroomCreator c = new MushroomCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "123");
            c.FactoryMethod(d);
        }
    }
}
