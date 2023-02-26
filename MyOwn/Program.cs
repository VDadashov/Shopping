using MyOwn.Enums;
using MyOwn.MainProduct;
using MyOwn.Models;
using MyOwn.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

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
                Console.WriteLine("\n1. SmartPhone Category");
                Console.WriteLine("2. Notebook Category");
                Console.WriteLine("3. Tv Category");
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
                                    KontaktHome.GetSmartPhone();
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

                        #region Mainfeatures
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
                            categoryStr = Console.ReadLine();
                        } while (!Enum.TryParse(typeof(TypeCategory), categoryStr, out category));

                        Console.Write("Model: ");
                        string model = Console.ReadLine();

                        string priceStr;
                        double price;
                        do
                        {
                            Console.Write("Price: ");
                            priceStr = Console.ReadLine();

                        } while (!double.TryParse(priceStr, out price));

                        string disCountPercentStr;
                        double disCountPercent;
                        do
                        {
                            Console.Write("DisCountPercent: ");
                            disCountPercentStr = Console.ReadLine();

                        } while (!double.TryParse(disCountPercentStr, out disCountPercent));
                        #endregion

                        #region AddSmartPhone

                        SmartPhone wantedPhone = new SmartPhone();

                        if (Convert.ToString(category) == "SmartPhone")
                        {

                            wantedPhone.Category = (TypeCategory)category;
                            wantedPhone.Model = model;
                            wantedPhone.Price = price;
                            wantedPhone.DisCountPercent = disCountPercent;

                            SmartPhoneObject(ref wantedPhone);

                            KontaktHome.AddProduct(wantedPhone);
                        }
                        #endregion

                        #region AddNotebook
                        NoteBook wantedNotebook = new NoteBook();

                        if (Convert.ToString(category) == "Notebook")
                        {
                            wantedNotebook.Category = (TypeCategory)category;
                            wantedNotebook.Model = model;
                            wantedNotebook.Price = price;
                            wantedNotebook.DisCountPercent = disCountPercent;

                            NoteBookObject(ref wantedNotebook);
                            KontaktHome.AddProduct(wantedNotebook);
                        }
                        #endregion

                        #region AddTv
                        Tv wantedTv = new Tv();

                        if (Convert.ToString(category) == "Tv")
                        {
                            
                        }
                        #endregion
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

        static void SmartPhoneObject(ref SmartPhone smartPhone)
        {

            Console.WriteLine("---Available OP---");
            foreach (var item in Enum.GetValues(typeof(TypeOPSP)))
            {
                Console.WriteLine($"{item} - {(int)item}");
            }

            Console.WriteLine("-----------");

            string operitingSystemStr;
            object operitingSystem;
            do
            {
                Console.Write("OP: ");
                operitingSystemStr = Console.ReadLine();
            } while (!Enum.TryParse(typeof(TypeOPSP), operitingSystemStr, out operitingSystem));


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
                colorStr = Console.ReadLine();

            } while (!Enum.TryParse(typeof(TypeColorSP), colorStr, out color));

            string ramStr;
            byte ram;
            do
            {
                Console.Write("RAM: ");
                ramStr = Console.ReadLine();
            } while (!byte.TryParse(ramStr, out ram) && ram < 32);

            string simCardCountStr;
            byte simCardCount;
            do
            {
                Console.Write("SimCardCount: ");
                simCardCountStr = Console.ReadLine();
            } while (!byte.TryParse(simCardCountStr, out simCardCount) && simCardCount <= 2);

            smartPhone.OperatingSystem = (TypeOPSP)operitingSystem;
            smartPhone.Color = (TypeColorSP)color;
            smartPhone.RAM = ram;
            smartPhone.SimCardCount = simCardCount;

            

        }

        static void NoteBookObject(ref NoteBook noteBook)
        {
            Console.WriteLine("---Avialable Color---");
            foreach (var item in Enum.GetValues(typeof(TypeColorNT)))
            {
                Console.WriteLine($"{item} - {(int)item}");
            }
            Console.WriteLine("-----------");

            string colorStr1;
            object color;
            do
            {
                Console.Write("Color: ");
                colorStr1 = Console.ReadLine();
            } while (!Enum.TryParse(typeof(TypeColorNT), colorStr1, out color));

            string processor;
            do
            {
                Console.Write("Processor: ");
                processor = Console.ReadLine();
            } while (!NoteBook.CheckProcessor(processor));

            string videCard;
            do
            {
                Console.Write("VideoCard: ");
                videCard = Console.ReadLine();
            } while (!NoteBook.CheckVideoCard(videCard));

            string ssdStr;
            int ssd;
            do
            {
                Console.Write("SSD: ");
                ssdStr = Console.ReadLine();
            } while (!int.TryParse(ssdStr, out ssd) && (ssd >= 0 && ssd <= 1024));
        }

        static void TvObject(ref Tv tv)
        {

        }


    }
}
