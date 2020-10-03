using System;
using System.Collections.Generic;
using System.Linq;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"Country.csv";
            CsvReader reader = new CsvReader(filePath);

            /*List<Country> countries = reader.ReadAllCountries();
            var filteredCountries = countries.Where(x => !x.Name.Contains(',')).Take(5);
            var filteredCountries1 = from country in countries
                                     where !country.Name.Contains(',')
                                     select country;*/


            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();

            foreach (string region  in countries.Keys)
                    System.Console.WriteLine(region);

            Console.Write("Which of the above regions do you want ?");
            string chosenRegion = Console.ReadLine();

            if(countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                    Console.WriteLine($"{country.Population} : {country.Name}");
            }
            else
            {
                Console.WriteLine("That is not a valid region");
            }

            System.Console.WriteLine($"{countries.Count} countries");
        }
    

    }

}