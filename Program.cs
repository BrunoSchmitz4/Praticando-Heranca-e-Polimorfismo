using DecQuintApp.Entities;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using DecQuintApp.EntitiesProd;

namespace DecQuintApp
{
    class Program
    {
        // Exercício desafio

        static void Main(string[] args)
        {
            Products();
        }

        static public void Products()
        {

            Console.WriteLine("-----Lista de Produtos-----");
            List<Product> prods = new List<Product>();
            Console.Write("Número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            
            // Resolver problema de i inacessível
            for (int i = 0; i < n; i++)
            {
                string option = "";
                option.ToUpper();
                while ((option != "NO") || (option != "US") || (option != "IM"))
                {
                    //Console.WriteLine(option);
                    Console.WriteLine($"Dados do produto {i + 1}");
                    Console.Write("Qual o status do produto?\n(N) - Normal | (U) - Usado | (I) - Importado: ");
                    option = Console.ReadLine().ToUpper();
                    option.ToUpper();
                    if (option == "NO" || option == "n")
                    {
                        Console.Clear();
                        Console.Write("Nome do produto: ");
                        string name = Console.ReadLine();
                        Console.Write("Preço do produto: R$ ");
                        double price = double.Parse(Console.ReadLine());
                        prods.Add(new Product(name, price));
                    }
                    else if ((option == "US") || option == "u")
                    {
                        Console.Clear();
                        Console.Write("Nome do produto: ");
                        string name = Console.ReadLine();
                        Console.Write("Preço do produto: R$ ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Data de fabricação: (DD/MM/YYYY)");
                        DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        prods.Add(new UsedProduct(name, price, date));
                    }
                    else if ((option == "IM") || option == "i")
                    {
                        Console.Clear();
                        Console.Write("Nome do produto: ");
                        string name = Console.ReadLine();
                        Console.Write("Preço do produto: R$ ");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Taxa dee alfândega: ");
                        double taxacao = double.Parse(Console.ReadLine());
                        prods.Add(new ImportedProduct(name, price, taxacao));
                    }
                }
                break;
            }
            Console.Clear();
            Console.WriteLine("|-----Lista de Produtos-----|");
            foreach (Product p in prods)
            {
                if(p is ImportedProduct)
                {
                    ImportedProduct p2 = p as ImportedProduct;
                    //Console.WriteLine($"Nome: {p2.Name}" +
                    //$"\nPreço: {p2.TotalPrice()}" +
                    //$"\nTaxa de Alfândega: {p2.CustomsFee}");
                    Console.WriteLine($"{p2.PriceTag}");
                }
                else if(p is UsedProduct)
                {
                    UsedProduct p2 = p as UsedProduct;
                    //Console.WriteLine($"Nome: {p2.Name}" +
                    //$"\nPreço: {p2.PriceTag()}" +
                    //$"\nTaxa de Alfândega: {p2.ManufactureDate}");
                    Console.WriteLine($"{p2.PriceTag}");
                }
                else
                {
                    Console.WriteLine($"{p.PriceTag}");
                }
                
            }
        }
        static public void Emps()
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the numbers of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced?(y/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value p/hour: R$");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.Clear();

            // Execução polimórfica
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}