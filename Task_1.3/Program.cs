using System;
using System.Collections.Generic;

namespace Task_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Region, RegionSettings> dictionary = new Dictionary<Region, RegionSettings>();
            uint n = 0;

            Console.WriteLine(" Task 1.3 The Dictionary with Key\n Voronova Emilia");
            Console.WriteLine(" Enter a number of elements in the dictionary.  Enter exit to leave the program.");
            while (!uint.TryParse(Console.ReadLine(), out n) || n == 0)
            {
                Console.WriteLine(" Incorrect input. Enter a positive number of elements.");
            }
            for (int i = 0; i < n; i++)
            {
                Region region;
                Console.WriteLine("\n Enter brand   : ");
                string brand = Console.ReadLine();
                if (brand.Equals("exit"))
                    break;
                Console.WriteLine(" Enter country : ");
                string country = Console.ReadLine();
                if (country.Equals("exit"))
                    break;
                region = new Region(brand, country);
                Console.WriteLine(" Enter website : ");
                string website = Console.ReadLine();
                if (website.Equals("exit"))
                    break;
                while (!dictionary.TryAdd(region, new RegionSettings(website)))
                {
                    Console.WriteLine("You have duplicated your region. Try again.");
                    Console.WriteLine("\n Enter brand   : ");
                    brand = Console.ReadLine();
                    if (brand.Equals("exit"))
                        break;
                    Console.WriteLine(" Enter country : ");
                    country = Console.ReadLine();
                    if (country.Equals("exit"))
                        break;
                    region = new Region(brand, country);
                    Console.WriteLine(" Enter website : ");
                    website = Console.ReadLine();
                    if (website.Equals("exit"))
                        break;
                }
            }
            Console.WriteLine("\n Your dictionary is : \n");
            foreach (var region in dictionary)
                Console.WriteLine(region.Key + "" + region.Value);
        }
    }
}
