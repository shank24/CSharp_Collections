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


            List<Country> countries = reader.ReadAllCountries();

            var filteredCountries = countries.Where(x => !x.Name.Contains(',')).Take(5);
            
            var filteredCountries1 = from country in countries
                                     where !country.Name.Contains(',')
                                     select country;

            foreach (Country country in filteredCountries1)
            {
                System.Console.WriteLine($"{country.Population} : {country.Name}");
            }


            System.Console.WriteLine($"{countries.Count} countries");
        }


    }

}