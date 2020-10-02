using System;
using System.ComponentModel.Design;
using System.IO;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo start_om = new DirectoryInfo(@"C:\Users\88ziaale\Desktop\C# Data");
            DirectoryInfo skrivBord = new DirectoryInfo(@"C:\Users\88ziaale\Desktop\C# Data");
           start: 
                foreach (var dir in skrivBord.GetDirectories()) 
            { 
                foreach (var file in skrivBord.GetFileSystemInfos())
                   {
                       Console.WriteLine(file);
                   }
                
                if(Console.ReadKey().Key == ConsoleKey.DownArrow)
                { 
                    if (skrivBord.ToString() != @"C:\")
                    {
                        skrivBord = skrivBord.Parent;
                        goto start;
                    }
                }
                else if(Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                       skrivBord = start_om;
                }
                else
                {   Console.WriteLine();
                    Console.WriteLine("Du kan bara använda pilen uppåt och pilen neråt");
                    Console.WriteLine();
                    goto start;
                }
            }
        }
    }
}
