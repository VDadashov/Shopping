using MyOwn.Models;
using System;

namespace MyOwn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoteBook noteBook = new NoteBook();
            noteBook.Processor = "i7";
            Console.WriteLine(noteBook.Processor);
            noteBook.VideoCard = "GTX1650";
            Console.WriteLine(noteBook.VideoCard);
        }
    }
}
