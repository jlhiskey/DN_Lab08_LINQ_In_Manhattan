using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DN_Lab08_LINQ_In_Manhattan.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DN_Lab08_LINQ_In_Manhattan
{
    public class Program
    {
        static void Main(string[] args)
        {
            string _filePath = @"c:\Users\Jason Hiskey\Documents\codefellows\#401\labs\DN_Lab08_LINQ_In_Manhattan\DN_Lab08_LINQ_In_Manhattan\DN_Lab08_LINQ_In_Manhattan\assets\data.json";

            JObject jObject = CreateJsonObject(_filePath);
            
            AllFeatures masterList = new AllFeatures();

            masterList = ParseJsonObjectToDotNetObject(jObject);

            //Output all Neighborhoods
            QueryOne(masterList);
            //Filter out neighborhoods that dont have a name.
            //Remove duplicates
            //Rewrite all of the above queries into one query.
            
        }

        /// <summary>
        /// Reads a .json file and returns a JOBject
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>JObject</returns>
        public static JObject CreateJsonObject(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                JObject allData = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                
                return allData;
            }
        }

        /// <summary>
        /// Takes JObject and converts it to .NET object.
        /// </summary>
        /// <param name="jsonData"></param>
        /// <returns>Object</returns>
        public static AllFeatures ParseJsonObjectToDotNetObject(JObject jsonData)
        {
            AllFeatures allFeatures = jsonData.ToObject<AllFeatures>();
            return allFeatures;
        }

        static void QueryOne(AllFeatures allFeatures)
        {
            var allNeighborhoods = allFeatures.Features.Select(x => x.Properties.Neighborhood);

            foreach (string neighborhood in allNeighborhoods)
            {
                if (neighborhood == "")
                {
                    Console.WriteLine("NULL NAME");
                }
                else
                {
                    Console.WriteLine(neighborhood);
                }
            }
        }    
    }
}
