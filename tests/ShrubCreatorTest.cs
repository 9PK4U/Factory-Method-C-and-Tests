using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab3.Plants;
using Lab3;

namespace UnitTestsLab3
{
    [TestClass]
    public class ShrubCreatorTest
    {
        [TestMethod]
        public void CreateCurrentShrub()
        {
            ShrubCreator c = new ShrubCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Shrub-s");
            d.Add("Height", "123");
            d.Add("Month Flowering", "3");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateShrubWithWrongValueName()
        {
            ShrubCreator c = new ShrubCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "shrub");
            d.Add("Height", "123");
            d.Add("Month", "3");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateShrubWithWrongValueHeight()
        {
            ShrubCreator c = new ShrubCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Shrub");
            d.Add("Height", "-123");
            d.Add("Month", "3");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateShrubWithWrongValueMonth()
        {
            ShrubCreator c = new ShrubCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "123");
            d.Add("Month", "14");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateShrub_ParametersCountMoreThanNeed()
        {
            ShrubCreator c = new ShrubCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "123");
            d.Add("Month", "3");
            d.Add("Color", "Black");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateShrub_ParametersCountLessThanNeed()
        {
            ShrubCreator c = new ShrubCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "123");
            c.FactoryMethod(d);
        }
    }
}
