using DecQuintApp.Entities;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using DecQuintApp.EntitiesProd;
using DecQuintApp.EntitiesShape;

namespace DecQuintApp
{
    // Fazer um programa que leia os dados de n figuras;
    // O programa mostrará a área das figuras
    // na ordem que foram adicionadas.
    // u can do it!:)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas formas desejas inserir?");
            int n = int.Parse(Console.ReadLine());
            List<Shape> formas = new List<Shape>();
            for (int i = 0; i < n;)
            {
                
                string option = "";
                string colorOption = "";
                option.ToUpper();
                while ((option != "R" || option != "C") && i < n)
                {

                    Console.WriteLine("Escolha uma forma geométrica:\n" +
                        "(R) - Retângulo | (C) - Círculo");
                    option = Console.ReadLine().ToUpper();
                    option.ToUpper();
                    var cor = System.Drawing.Color.Black;
                    if (option == "R")
                    {
                        Console.WriteLine($"Criando {i + 1}° forma das {n} pedidas");

                        Console.Write("Altura: ");
                        double altura = double.Parse(Console.ReadLine());
                        Console.Write("Largura: ");
                        double largura = double.Parse(Console.ReadLine());
                        Console.Write("Escolha uma cor: (P) - Preto | (V) - Vermelho | (A) - Azul: ");
                        colorOption = Console.ReadLine().ToUpper();
                        colorOption.ToUpper();
                        if (colorOption == "P" || colorOption == "p")
                        {
                            //cor = "Black";
                            cor = System.Drawing.Color.Black;
                        }
                        else if (colorOption == "V" || colorOption == "v")
                        {
                            //cor = "Red";
                            cor = System.Drawing.Color.Red;
                        }
                        else if (colorOption == "A" || colorOption == "a")
                        {
                            //cor = "Blue";
                            cor = System.Drawing.Color.Blue;
                        }
                        //while ((colorOption != "P") || (colorOption != "V") || (colorOption != "A"))
                        //{
                        //    Console.Write("Escolha uma cor: (P) - Preto | (V) - Vermelho | (A) - Azul: ");
                        //    colorOption = Console.ReadLine().ToUpper();
                        //    colorOption.ToUpper();
                        //    if (colorOption == "P" || colorOption == "p")
                        //    {
                        //        //cor = "Black";
                        //        cor = System.Drawing.Color.Black;
                        //    }
                        //    else if (colorOption == "V" || colorOption == "v")
                        //    {
                        //        //cor = "Red";
                        //        cor = System.Drawing.Color.Red;
                        //    }
                        //    else if (colorOption == "A" || colorOption == "a")
                        //    {
                        //        //cor = "Blue";
                        //        cor = System.Drawing.Color.Black;
                        //    }
                        //}
                        Shape reta = new Rectangule(largura, altura, cor);
                        formas.Add(reta);
                        i += 1;

                    }
                    else if(option == "C")
                    {
                        Console.WriteLine($"Criando {i + 1}° forma das {n} pedidas");

                        Console.Write("Raio: ");
                        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Escolha uma cor: (P) - Preto | (V) - Vermelho | (A) - Azul: ");
                        colorOption = Console.ReadLine().ToUpper();
                        colorOption.ToUpper();
                        if (colorOption == "P" || colorOption == "p")
                        {
                            //cor = "Black";
                            cor = System.Drawing.Color.Black;
                        }
                        else if (colorOption == "V" || colorOption == "v")
                        {
                            //cor = "Red";
                            cor = System.Drawing.Color.Red;
                        }
                        else if (colorOption == "A" || colorOption == "a")
                        {
                            //cor = "Blue";
                            cor = System.Drawing.Color.Blue;
                        }
                        //while (colorOption != "P" || colorOption != "V" || colorOption != "A")
                        //{
                        //    Console.Write("Escolha uma cor: (P) - Preto | (V) - Vermelho | (A) - Azul: ");
                        //    colorOption = Console.ReadLine().ToUpper();
                        //    colorOption.ToUpper();
                        //    if (colorOption == "P")
                        //    {
                        //        //cor = "Black";
                        //        cor = System.Drawing.Color.Black;
                        //    }
                        //    else if (colorOption == "V")
                        //    {
                        //        //cor = "Red";
                        //        cor = System.Drawing.Color.Red;
                        //    }
                        //    else if (colorOption == "A")
                        //    {
                        //        //cor = "Blue";
                        //        cor = System.Drawing.Color.Black;
                        //    }
                        //}
                        Shape circ = new Circle(raio, cor);
                        formas.Add(circ);
                        i += 1;
                    }
                }
                break;
            }
            Console.WriteLine("-----Formas Geométricas criadas-----");
            int c = 0;

            foreach (var f in formas)
            {
                
                //Console.WriteLine(f);
                if (f is Rectangule)
                {
                    Rectangule rectangule = f as Rectangule;
                    Console.WriteLine($"\nForma {c + 1}#: Retângulo | Cor: {rectangule.color} | Altura: {rectangule.Height}cm | Largura: {rectangule.Width}cm | Área: {rectangule.Area().ToString("F2", CultureInfo.InvariantCulture)}cm²");
                    c += 1;
                }
                if (f is Circle)
                {
                    Circle circle = f as Circle;
                    Console.WriteLine($"\nForma {c + 1}#: Círculo | Cor: {circle.color} | Raio: {circle.Radius.ToString("F2", CultureInfo.InvariantCulture)}cm² | Área: {circle.Area().ToString("F2", CultureInfo.InvariantCulture)}cm²");
                    c += 1;
                }
            }

            //Shape reta = new Rectangule(4, 5);
            //Shape circ = new Circle(6);

            //Console.WriteLine($"Área do retângulo: {reta.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"Área do círculo: {circ.Area().ToString("F2", CultureInfo.InvariantCulture)}");

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