using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace Uppgift_2
{
    class Navigerare
    {
       

        private DirectoryInfo aktuell_folder;
        private DirectoryInfo nästa_folder;
        private DirectoryInfo gånerEn_folder;

        public Navigerare(string path)
        {
            this.aktuell_folder = new DirectoryInfo(path);
            this.nästa_folder = new DirectoryInfo(path);
            this.gånerEn_folder = new DirectoryInfo(path);
        }
        public DirectoryInfo Vissa_Innehöll(int valrad)
        {
            int i = 0;
            DirectoryInfo vald_folder = null;
            Console.WriteLine(aktuell_folder.FullName);
            foreach (var folder in aktuell_folder.GetDirectories())
            {

                if (i == valrad)
                {
                    Console.WriteLine("Folder: {0} \t\t Skapad: {1} \t\t  <==", folder.Name, folder.CreationTime);
                    vald_folder = folder;
                } else
                {
                    Console.WriteLine("Folder: {0} \t\t Skapad: {1}", folder.Name, folder.CreationTime);
                }
                i++;

            }
            foreach (var file in aktuell_folder.GetFiles())
            {
                Console.WriteLine("Filer: {0}\t\t Skapad: {1} \t\t Storlek: {2} kb ", file.Name, file.CreationTime, file.Length);
            }

            return vald_folder;
        }
        public int vissa_storlek()
        {
            return aktuell_folder.GetDirectories().Length;
        }
        public void GåuppEnFolder()
        {
            if (aktuell_folder.ToString() != @"C:\")
            {
                aktuell_folder = aktuell_folder.Parent;
            }
        }
        public void gånerEn_Folder(DirectoryInfo vald_folder)
        {
            if (vald_folder != null)
            {
            aktuell_folder = vald_folder;
            }
        }
    }
}
