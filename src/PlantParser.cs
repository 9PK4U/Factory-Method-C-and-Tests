using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace Lab_3
{
    public class PlantParser
    {
        private int counter;
        private string pathFile;
        private CircularLinkedList<IPlant> plantsList;
        private CircularLinkedList<LogItem> logItemsList;
        private Dictionary<string, Dictionary<string, string>[]> data;
        public CircularLinkedList<PlantCreator> CreatorsList = new CircularLinkedList<PlantCreator>();
        public CircularLinkedList<IPlant> PlantsList { get { return plantsList; } }
        public CircularLinkedList<LogItem> LogItemsList { get { return logItemsList; } }
        public void ParseFile()
        {
            string jsonString = File.ReadAllText(pathFile);
            data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>[]>>(jsonString);
            foreach (var el in data)
            {
                foreach (var val in el.Value)
                {
                    counter++;
                    ParseObject(val, el.Key);
                }
            }
        }
        private void ParseObject(Dictionary<string, string> parameters, string objectType)
        {
            foreach (var creator in CreatorsList)
                if (creator.Type == objectType)
                {
                    try
                    {
                        PlantsList.Add(creator.FactoryMethod(parameters));
                        return;
                    }
                    catch (Exception e)
                    {
                        LogItemsList.Add(new LogItem(counter, e.Message));
                        return;
                    }
                }
            LogItemsList.Add(new LogItem(counter, "Unexpected Type:" + objectType));
        }
        public PlantParser(string pathFile)
        {
            this.pathFile = pathFile;
            CreatorsList = new CircularLinkedList<PlantCreator>();
            plantsList = new CircularLinkedList<IPlant>();
            logItemsList = new CircularLinkedList<LogItem>();
        }
    }
}
