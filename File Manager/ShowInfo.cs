using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace File_Manager
{
    public class ShowInfo
    {
        public ShowInfo()
        {
            DirInfo = "Uknown";
        }
        public ShowInfo(string dirinfo)
        {
            DirInfo = dirinfo;
        }
        public string DirInfo { get; }

        public override string ToString()
        {
            return DirInfo;
        }

        public static string CurrentDir()
        {
            Console.WriteLine("Enter path");
            string DirInfo = Console.ReadLine();
            Console.WriteLine("Current directory  is: {0} \n", DirInfo);
            return DirInfo;
        }

        //Выводит список папок в директории в сокращенной записи
        public void ShowDir()
        {
            //Console.WriteLine("Enter path");
            //string pathString = Console.ReadLine();
            string pathstring = DirInfo;
            Console.WriteLine("====================================================================");
            Console.WriteLine("The directory {0} contains the following directories: \n", DirInfo);
            foreach (string folder in Directory.GetDirectories(DirInfo))
            {
                Console.WriteLine(Path.GetFileName(folder));
            }
            Console.WriteLine("====================================================================");
        }
        //Выводит список файлов в ПАПКЕ и их размер без указания пути
        public void ShowFiles()
        {
            //Console.WriteLine("Enter path");
            //string pathString = Console.ReadLine();
            string pathString = DirInfo;
            DirectoryInfo directory = new DirectoryInfo(DirInfo);
            FileInfo[] fileArray = directory.GetFiles();
            Console.WriteLine("====================================================================");
            Console.WriteLine("The directory {0} contains the following files: \n", directory.Name);
            foreach (FileInfo file in fileArray)
            {
                Console.WriteLine($"{file.Name}, | {file.Length} bytes");
            }
            Console.WriteLine("====================================================================");
        }

        //Выводит список папок с полным путем
        public void ShowDirectory()
        {
            string pathstring = DirInfo;
            string[] directoryArray = Directory.GetDirectories(DirInfo);
            foreach (string directory in directoryArray)
            {

                Console.WriteLine($"{directory}");

            }
        }
        //Выводит общий размер папки
        public static long GetDirectorySize(string p)
        {

            string[] a = Directory.GetFiles(p, "*.*");
            long b = 0;
            foreach (string name in a)
            {
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            return b;

        }
        public void DirSize()
        {
            string pathstring = DirInfo;
            string[] directoryArray = Directory.GetDirectories(DirInfo);
            foreach (string directory in directoryArray)
            {
                Console.WriteLine($"{directory}, {directory.Length} bytes");
            }
        }
    }
}
