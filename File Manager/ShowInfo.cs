using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace File_Manager
{
    public class ShowInfo
    {

        public string DirInfo { get; set; }

        public string CurrentDir()
        {
            Console.WriteLine("Enter path");
            this.DirInfo = Console.ReadLine();
            Console.WriteLine("Current directory  is: {0} \n", DirInfo);
            return DirInfo;
        }

        //Выводит список папок в директории в сокращенной записи
        public void ShowDir()
        {
            //Console.WriteLine("Enter path");
            //string pathString = Console.ReadLine();
            Console.WriteLine("====================================================================");
            Console.WriteLine("The directory {0} contains the following directories: \n", this.DirInfo);
            foreach (var folder in Directory.GetDirectories(this.DirInfo))
            {
                Console.WriteLine(Path.GetFileName(folder));
            }
            Console.WriteLine("====================================================================");
        }
        //Выводит список файлов в ПАПКЕ и их размер без указания пути
        public void ShowFiles()
        {

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
            string[] directoryArray = Directory.GetDirectories(DirInfo);
            foreach (string directory in directoryArray)
            {
                Console.WriteLine($"{directory}");
            }
        }
        //Выводит общий размер папки
        public long GetDirectorySize()
        {
            string[] a = Directory.GetFiles(DirInfo, "*.*");
            long size = 0;
            foreach (string name in a)
            {
                FileInfo info = new FileInfo(name);
                size += info.Length;
            }
            Console.WriteLine("The Directory {0} size is {1} bytes ", DirInfo, size);
            return size;
            
        }
        public void DirSize()
        {
            string[] directoryArray = Directory.GetDirectories(DirInfo);
            foreach (string directory in directoryArray)
            {
                Console.WriteLine($"{directory}, {directory.Length} bytes");
            }
        }
    }
}
