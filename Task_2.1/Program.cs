using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Task_2._1
{
    class Program
    {
        static void Menu()
        {
            List<Product> products = new List<Product>();
            List<Tag> tags = new List<Tag>();
            List<Leftover> inventory = new List<Leftover>();
            try
            {
                products = File.ReadLines("Products.csv").Skip(1).Select(x => new Product(x.Split(';')[0],
                    x.Split(';')[1], x.Split(';')[2], Convert.ToDecimal(x.Split(';')[3]))).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine(" Products data is incorrect.");
                Environment.Exit(-1);
            }
            try
            {
                tags = File.ReadLines("Tags.csv").Skip(1).Select(x => new Tag(x.Split(';')[0],
                    x.Split(';')[1])).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine(" Tags data is incorrect.");
                Environment.Exit(-1);
            }
            try
            {
                inventory = File.ReadLines("Inventory.csv").Skip(1).Select(x => new Leftover(x.Split(';')[0],
                    x.Split(';')[1], Convert.ToInt32(x.Split(';')[2]))).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine(" Leftovers data is incorrect.");
                Environment.Exit(-1);
            }

            Console.WriteLine("\n Main menu\n ---------\n 1. Exit\n 2. Products\n 3. Leftovers\n");
            Console.WriteLine(" Enter command number : ");
            int command;
            while (!int.TryParse(Console.ReadLine(), out command) || command > 3 || command < 1)
            {
                Console.WriteLine(" Invalid command. Enter valid command number : ");
            }
            switch (command)
            {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    Console.WriteLine(" 1. Go back to menu\n 2. Search product\n 3. Products list ascending\n 4. Products list descending");
                    Console.WriteLine(" Enter command : ");
                    int secondCommand;
                    while (!int.TryParse(Console.ReadLine(), out secondCommand) || secondCommand > 4 || secondCommand < 1)
                    {
                        Console.WriteLine(" Invalid command. Enter valid command : ");
                    }
                    switch (secondCommand)
                    {
                        case 1:
                            {
                                Menu();
                                break;
                            }
                        case 2:
                            {
                                var result = new List<string>();
                                Console.WriteLine("Enter search criteria : ");
                                string criteria = Console.ReadLine();
                                bool isFound = false;
                                products.Where(x => x.Id.ToLower() == criteria.ToLower()).ToList().ForEach(x => result.Add(x + " " ));
                                products.Where(x => x.Brand.ToLower().Contains(criteria.ToLower())).ToList().ForEach(x => result.Add(x + " "));
                                
                                if (result.Count > 0)
                                {
                                    var output = result.Distinct().ToList();
                                    output.ForEach(Console.WriteLine);
                                }  
                                else
                                    Console.WriteLine("No such product");
                                Menu();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine(" Products list ascending :\n");
                                products.OrderBy(x => x.Price).ToList().ForEach(Console.WriteLine);
                                Menu();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine(" Products list descending :\n");
                                products.Distinct().OrderByDescending(x => x.Price).ToList().ForEach(Console.WriteLine);
                                Menu();
                                break;
                            }
                    }
                    break;
                case 3:
                    Console.WriteLine(" 1. Go back to menu\n 2. Missing products\n 3. Leftovers list ascending\n 4. Leftovers list descending\n 5.Leftovers by ID");
                    Console.WriteLine(" Enter command : ");
                    int thirdCommand;
                    while (!int.TryParse(Console.ReadLine(), out thirdCommand) || thirdCommand > 5 || thirdCommand < 1)
                    {
                        Console.WriteLine(" Invalid command. Enter valid command : ");
                    }
                    switch (thirdCommand)
                    {
                        case 1:
                            Environment.Exit(0);
                            break;
                        case 2:
                            Console.WriteLine("Not realised yet, sorry");
                            Menu();
                            //var result = new List<string>();
                            //if (result.Count > 0)
                            //{
                            //    var output = result.Select(x => x == x).Distinct().ToList();
                            //    output.ForEach(Console.WriteLine);
                            //}
                            break;
                        case 3:
                            Console.WriteLine(" Leftovers list ascending :\n");
                            inventory.OrderBy(x => x.LeftoverAmount).ToList().ForEach(Console.WriteLine);
                            Menu();
                            break;
                        case 4:
                            Console.WriteLine(" Leftovers list descending :\n");
                            inventory.OrderByDescending(x => x.LeftoverAmount).ToList().ForEach(Console.WriteLine);
                            Menu();
                            break;
                        case 5:
                            Console.WriteLine("Not realised yet, sorry");
                            Menu();
                            break;
                    }
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 2.1 ERP reports bot\n Voronova Emilia");
            Console.WriteLine(" Welcome to ERP Reports bot.\n You can interact with broducts through this bot." +
                "\n Here is the list of available commands : ");
            Menu();
        }
    }
}
