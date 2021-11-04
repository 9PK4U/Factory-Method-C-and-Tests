using System;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PlantParser p = new PlantParser("PATH");
            p.CreatorsList.Add(new TreeCreator());
            p.CreatorsList.Add(new ShrubCreator());
            p.CreatorsList.Add(new MushroomCreator());
            p.ParseFile();
            var plants = p.PlantsList;
            var logs = p.LogItemsList;
            //plants.Remove(plants[1]);
            //var pl = plants.OrderBy(p => p.Name);
            Console.WriteLine("Plants: " + plants.Count);
            plants.Show();
            Console.WriteLine("Logs: " + logs.Count);
            logs.Show();
            Console.ReadKey();
        }
    }
}
