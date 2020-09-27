using System.Collections.Generic;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"Country.csv";
            CsvReader reader = new CsvReader(filePath);


            List<Country> countries = reader.ReadAllCountries();
            
        
            foreach (Country country in countries))
            {
                System.Console.WriteLine($"{country.Population} : {country.Name}");
            }


            System.Console.WriteLine($"{countries.Count} countries");
        }


    }

}