using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;

namespace Uppgift_2
{   /*
     Raporten: 
    Jag har försökte göra ett program, 
    jag har fastnat några gångar då fick jag hjälpt av lärarinna och googlade att hitta låsning 
    jag har försökte göra min bästa och jag la allt min kunskap som jag fick under den här kursen 
    till slut likades jag att göra den här programen. 
   
Vad mitt program ska göra!

    1 kunna visa alla filer i en folder

    2 kunna gå till föräldrafoldern (om användaren trycker på pil upp) och visa filer där

    3 kunna välja en barn folder visuellt med höger/vänster pil
        help.txt 		        2014-04-12               4kb
        my filés 		        2014-05-11               --
        folder 		            2014-05-11               --     <–
        Another folder 		    2014-05-11               --
    
        (trycker på höger pil) 

        help.txt 		        2014-04-12              4kb
        my filés 		        2014-05-11              --
        folder 		            2014-05-11              --             
        Another folder          2014-05-11     	        --      <–

    4 kunna gå ner till den valda foldern med 'pil ner'

    5 Skapa Navigerare klassen som håller koll på DirectoryInfo objektet

     */


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     * * * * * * * * * * * * * * * * * * ");
            Console.WriteLine("     *   Välkommen till Navigeraren!   * ");
            Console.WriteLine("     * * * * * * * * * * * * * * * * * * ");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Du kan bara använda pil kannapor för att navigera\n\nTryck på enter knappen att gå vidar: "); 
            Console.Read();
            Navigerare navi = new Navigerare(Directory.GetCurrentDirectory());
            int valrad = 0;
            DirectoryInfo vald_folder = navi.Vissa_Innehöll(valrad);




            while (true) //varje iteration av while-loopen är en knapptryckning
            {
                // samla input från användaren
                ConsoleKeyInfo knapptryckning = Console.ReadKey(true);
                Console.Clear();
              
                if (knapptryckning.Key == ConsoleKey.UpArrow)
                {
                    navi.GåuppEnFolder();
                    vald_folder = navi.Vissa_Innehöll(valrad);
                    Console.WriteLine();
                }
                else if (knapptryckning.Key == ConsoleKey.DownArrow)
                {
                    navi.gånerEn_Folder(vald_folder);
                    vald_folder = navi.Vissa_Innehöll(valrad);
                    Console.WriteLine();
                }
                else if (knapptryckning.Key == ConsoleKey.LeftArrow)
                {
                    if (valrad < navi.vissa_storlek() - 1)
                    {
                        valrad += 1;
                    }
                    else
                    {
                        valrad = 0;
                    }
                    vald_folder = navi.Vissa_Innehöll(valrad);
                    Console.WriteLine();
                }
                else if (knapptryckning.Key == ConsoleKey.RightArrow)
                {
                    if (valrad == 0)
                    {
                        valrad = navi.vissa_storlek() - 1; // - 1 ett är för noll-indexeringens skull. 
                    }
                    else
                    {
                        valrad -= 1;
                    }
                    vald_folder = navi.Vissa_Innehöll(valrad);
                    Console.WriteLine();
                }        
            }
        }
    }
}
