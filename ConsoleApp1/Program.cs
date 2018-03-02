using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C:/Users/Jon_Sverrisson/Source/Repos/ConsoleApp1/ConsoleApp1/data.json";
            using (StreamReader str = new StreamReader(filepath))
            {
                string json = str.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Model>(json);


                Console.WriteLine(items);
            }

        }
    }
}
