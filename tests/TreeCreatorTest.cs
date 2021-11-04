using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab3;
using Lab3.Plants;

namespace UnitTestsLab3
{
    [TestClass]
    public class TreeCreatorTest
    {
        [TestMethod]
        public void CreateCurrentTree()
        {
            TreeCreator c = new TreeCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree-t");
            d.Add("Height", "123");
            d.Add("Age", "333");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateTreeWithWrongValueName()
        {
            TreeCreator c = new TreeCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "tree");
            d.Add("Height", "123");
            d.Add("Age", "333");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateTreeWithWrongValueHeight()
        {
            TreeCreator c = new TreeCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "-123");
            d.Add("Age", "333");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateTreeWithWrongValueAge()
        {
            TreeCreator c = new TreeCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "123");
            d.Add("Age", "-333");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateTree_ParametersCountMoreThanNeed()
        {
            TreeCreator c = new TreeCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "123");
            d.Add("Age", "333");
            d.Add("Color", "Black");
            c.FactoryMethod(d);
        }
        [TestMethod]
        public void CreateTree_ParametersCountLessThanNeed()
        {
            TreeCreator c = new TreeCreator();
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name", "Tree");
            d.Add("Height", "123");
            c.FactoryMethod(d);
        }
    }
}
