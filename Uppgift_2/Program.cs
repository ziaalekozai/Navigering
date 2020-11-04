using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;

namespace Uppgift_2
{
    //OBS Skriv rapporten samtidigt som du kodar!
    /*
    Här kan du skriva rapporten
    */

    /* Vad mitt programm ska göra!

    1 kunna visa alla filer i en folder

    2 kunna gå till föräldrafoldern (om användaren trycker på pil upp) och visa filer där

    3 kunna välja en barn folder visuellt med höger/vänster pil
        help.txt         2014-04-12           4kb
        my_files         2014-05-11           --
        folder           2014-05-11           --             <--
        another_folder   2014-05-11           --

        (trycker på höger pil) 

        help.txt         2014-04-12           4kb
        my_files         2014-05-11           --
        folder           2014-05-11           --             
        another_folder   2014-05-11           --             <--

    4 kunna gå ner till den valda foldern med 'pil ner'

    5 Skapa Navigerare klassen som håller koll på DirectoryInfo objektet

    */
   class Program
   {
       static void Main(string[] args)
       {
            //Console.WriteLine("Hej och vällkomen! \n\nFör att vissa filer trycka på pilen upp och för att vissa folder tryck på pilen ner");
            //Console.WriteLine();

            string path = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(@"c:\Users");
         
           foreach (var folder in dir.GetDirectories())
            {
                Console.WriteLine("{0} \t\t Skapad: {1}", folder.FullName, folder.CreationTime);

                foreach (var file in dir.GetFiles())
                {
                    Console.WriteLine("{0}\t Skapad: {1}\tStorlek: {2}kb",file, file.CreationTime, file.Length);

                    while (true)
                    {
                     try
                     {
                       if(Console.ReadKey().Key == ConsoleKey.DownArrow)
                            {
                                
                            }
                            else if(Console.ReadKey().Key == ConsoleKey.UpArrow)
                       {
                       }
                     }
                        catch (Exception)
                            {
                                throw;
                            }

                   }
               }
           }
       }
   }
}
           
        //} while (true)
        //    {

        //        if (Console.ReadKey().Key == ConsoleKey.DownArrow)
        //        {
        //            if (dir.ToString() != @"C:\")
        //            {
        //                dir = dir.Parent;
        //                //TODO pröva att använda 'continue'
        //            }
        //        }
        //        else if (Console.ReadKey().Key == ConsoleKey.UpArrow)
        //        {

        //        }
        //        else
        //        {
        //            //TODO Gör så att man kan välja vilken folder man går ner till via höger/vänster pil

        //        }
        //    }
  
      //{
            //    //Kolla vad användaren gör
            //    if (Console.ReadKey().Key == ConsoleKey.DownArrow)
            //    {
            //        //gör något beroende på användaren
            //        if (skrivBord.ToString() != @"C:\")
            //        {
            //            skrivBord = skrivBord.Parent;
            //        }
            //    }


            //    //visa resultatet
            //    foreach (var file in skrivBord.GetFileSystemInfos())
            //    {
            //        Console.WriteLine(file);
            //        skrivBord = skrivBord.Parent;
            //    }
            //}
        
        //{
        //    string path = Directory.GetCurrentDirectory();
        //    DirectoryInfo skrivbord = new DirectoryInfo(path); //TODO använd path variablen istället för denna 'absolute path' du har nu
        //    Console.WriteLine(skrivbord);




        ///*
        //start: //TODO Använd en while-sats istället för goto

        //    foreach (var dir in skrivBord.GetDirectories())
        //    {
        //        foreach (var file in skrivBord.GetFileSystemInfos())
        //        {
        //            Console.WriteLine(file);
        //        }

        //            goto start;

        //        }
        //    }
        //*/
        //

 
            