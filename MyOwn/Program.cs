using MyOwn.Enums;
using MyOwn.MainProduct;
using MyOwn.Models;
using MyOwn.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace MyOwn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop KontaktHome = new Shop();

            string option;
            do
            {
                Console.WriteLine("\n1. SmartPhone Show");
                Console.WriteLine("2. Notebook Show");
                Console.WriteLine("3. Tv Show");
                Console.WriteLine("4. Mehsul elave et");
                Console.WriteLine("5. Category ve Model e gore axtarish");
                Console.WriteLine("6. Qiymetine gore axtarish");
                Console.WriteLine("7. Endirimli qiymetine gore axtaris");
                Console.WriteLine("8. Mehsul'u sil");
                Console.WriteLine("----Menyu'dan cixmaq ucun Q ye basin----\n");

                Console.Write("Secim: ");
                option= Console.ReadLine();

                switch (option)
                {
                    case "1":

                        string opt;
                        do
                        {
                            Console.WriteLine("\n1. Butun Smartphone'lar i gorset");
                            Console.WriteLine("2. Rengine gore axtarish");
                            Console.WriteLine("3. Ram a gore axtarish");
                            Console.WriteLine("4. Endirimli mehsullari gorset");
                            Console.WriteLine("----Main Menyu qayitmaq ucun Q ye basin----\n");

                            Console.Write("Secim: ");
                            opt=Console.ReadLine();

                            switch (opt)
                            {
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                default:
                                    break;
                            }
                        } while (opt != "Q");
                        break;
                    case "2":

                        do
                        {
                            Console.WriteLine("1. Butun Notebooklar'i gorset");
                            Console.WriteLine("2. Rengine gore axtarish et");
                            Console.WriteLine("3. SSD e gore axtarish et");
                            Console.WriteLine("4. Endirimli Mehsullara bax");
                            Console.WriteLine("----Main Menyu qayitmaq ucun Q ye basin----\n");

                            Console.Write("Secim: ");
                            opt = Console.ReadLine();

                            switch (opt)
                            {
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                default:
                                    break;
                            }

                        } while (opt != "Q");

                        break;
                    case "3":

                        do
                        {
                            Console.WriteLine("1. Butun Tv'ler i gorset");
                            Console.WriteLine("2. Smart Tv dir'mi?");
                            Console.WriteLine("3. Voice Control var'mi?");
                            Console.WriteLine("4. Endirimli mehsullara bax");
                            Console.WriteLine("----Main Menyu qayitmaq ucun Q ye basin----\n");

                            Console.Write("Secim: ");
                            opt = Console.ReadLine();

                            switch (opt)
                            {
                                case "1":
                                    break;
                                case "2":
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                default:
                                    break;
                            }
                        } while (opt != "Q");

                        break;
                    case "4":

                        Console.WriteLine("---Own Category---");
                        foreach (var item in Enum.GetValues(typeof(TypeCategory)))
                        {
                            Console.WriteLine($"{item} - {(int)item}");
                        }

                        Console.WriteLine("-----------");
                        string categoryStr;
                        object category;
                        do
                        {
                            Console.Write("Category:");
                            categoryStr= Console.ReadLine();
                        } while (!Enum.TryParse(typeof(TypeCategory),categoryStr,out category));

                        Console.Write("Model: ");
                        string model = Console.ReadLine();

                        string priceStr;
                        double price;
                        do
                        {
                            Console.Write("Price: ");
                            priceStr= Console.ReadLine();

                        } while (!double.TryParse(priceStr,out price));

                        string disCountPercentStr;
                        double disCountPercent;
                        do
                        {
                            Console.Write("DisCountPercent: ");
                            disCountPercentStr= Console.ReadLine();

                        } while (!double.TryParse(disCountPercentStr,out disCountPercent));

                        if (Convert.ToString(category) == "SmartPhone")
                        {
                            Console.WriteLine("---Available colors---");
                            foreach (var item in Enum.GetValues(typeof(TypeColorSP)))
                            {
                                Console.WriteLine($"{item} - {(int)item}");
                            }

                            Console.WriteLine("-----------");
                            string colorStr;
                            object color;
                            do
                            {
                                Console.Write("Color: ");
                                colorStr= Console.ReadLine();

                            } while (!Enum.TryParse(typeof(TypeColorSP),colorStr,out color));
                        }
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    default:
                        break;
                }
            } while (option != "Q");
        }
    }
}
