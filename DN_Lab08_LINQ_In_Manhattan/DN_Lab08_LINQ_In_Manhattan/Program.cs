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
            
            Query(masterList);

            Console.ReadLine();
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

        /// <summary>
        /// Runs queries
        /// </summary>
        /// <param name="allFeatures"></param>
        static void Query(AllFeatures allFeatures)
        {
            //Query One
            var allNeighborhoods = allFeatures.Features.Select(x => x.Properties.Neighborhood);

            Console.WriteLine();
            Console.WriteLine("Query 1) Output all Neighborhoods. LAMBDA");
            Console.WriteLine();

            foreach (string neighborhood in allNeighborhoods)
            {
                if (neighborhood.Equals(""))
                {
                    Console.Write("NO NAME");
                }
                    Console.Write($"{neighborhood}, ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Query Two
            var namedNeighborhoods = allNeighborhoods.Where(x => x != "");

            Console.WriteLine("Query 2) Filter out neighborhoods that dont have a name. LAMBDA");
            Console.WriteLine();

            foreach (string namedNeighborhood in namedNeighborhoods)
            {
                Console.Write($"{namedNeighborhood}, ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Query Three
            var uniqueNeighborhoods = namedNeighborhoods.Distinct();

            Console.WriteLine("Query 3) Only prints neighborhoods that have a unique name. LAMBDA");
            Console.WriteLine();

            foreach (string uniqueNeighborhood in uniqueNeighborhoods)
            {
                Console.Write($"{uniqueNeighborhood}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
        
            //Query Four
            var allFiltersNeighborhoodsLambda = allFeatures.Features.Where(x => x.Properties.Neighborhood != "").Select(x => x.Properties.Neighborhood).Distinct();

            Console.WriteLine("Query 4) Only prints neighborhoods that have a unique name and filters out neigborhoods that have no name. LAMBDA");
            Console.WriteLine();

            foreach (string filteredNeighborhoodLambda in allFiltersNeighborhoodsLambda)
            {
                Console.Write($"{filteredNeighborhoodLambda}, ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Query Five
            var allFiltersNeighborhoodsLinq = (from item in allFeatures.Features
                                    where item.Properties.Neighborhood != ""
                                    select item.Properties.Neighborhood).Distinct();

            Console.WriteLine("Query 5) Only prints neighborhoods that have a unique name and filters out neigborhoods that have no name. LINQ");
            Console.WriteLine();

            foreach (string filteredNeigborhoodLinq in allFiltersNeighborhoodsLinq)
            {
                Console.Write($"{filteredNeigborhoodLinq}, ");
            }
        }
    }
}
