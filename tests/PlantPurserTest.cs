using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab3.Plants;
using Lab3;

namespace UnitTestsLab3
{
    [TestClass]
    public class PlantPurserTest
    {
        [TestMethod]
        public void CreatePlantPurser_ParseFileWithCurrentPath()
        {
            PlantParser p = new PlantParser("C:\\Users\\MZSTS\\Documents\\plants.json");
            p.ParseFile();
        }
        [TestMethod]
        public void CreatePlantPurser_ParseFileWithWrongPath()
        {
            PlantParser p = new PlantParser("C:\\Users\\MZSTS\\Documents\\plants1.json");
            p.ParseFile();
        }
        [TestMethod]
        public void CreatePlantPurser_ParseEmptyFile()
        {
            PlantParser p = new PlantParser("C:\\Users\\MZSTS\\Documents\\in.json");
            p.ParseFile();
        }
    }
}
