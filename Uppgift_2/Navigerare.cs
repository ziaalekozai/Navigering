using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Uppgift_2
{
    class Navigerare

    //private DirectoryInfo aktuell_folder;
    //TODO konstruktor där man skickar in en 'path' vart den ska börja
    {
        string path = Directory.GetCurrentDirectory();
        DirectoryInfo dir = new DirectoryInfo(@"c:\");
    }
    
    

        //TODO en metod GåUppEnFolder()
   
        //TODO en metod VäljNästaFolder()
        //TODO en metod VäljFöregåendeFolder()

        //TODO en metod GåNerValdFolder()

        //TODO en metod VisaNuvarandeFolderInnehåll()
    
}
