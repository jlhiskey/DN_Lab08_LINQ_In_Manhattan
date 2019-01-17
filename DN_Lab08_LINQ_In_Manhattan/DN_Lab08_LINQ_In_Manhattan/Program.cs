using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DN_Lab08_LINQ_In_Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            string _filePath = @"c:\Users\Jason Hiskey\Documents\codefellows\#401\labs\DN_Lab08_LINQ_In_Manhattan\DN_Lab08_LINQ_In_Manhattan\DN_Lab08_LINQ_In_Manhattan\assets\data.json";
            JObject test = ReadJson(_filePath);
            Console.WriteLine(test);
            
        }
        //Figure out how to look at JSON
        static JObject ReadJson(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                // do stuff
                return o;
            }
        }
        //Everything else after I know what I need to do.
        // Build some classes.
    }
}
