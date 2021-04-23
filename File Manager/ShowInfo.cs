using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace File_Manager
{
    public class ShowInfo
    {

        public string DirInfo { get; set; }

        public string CurrentDir()
        {
            try
            {
                Console.WriteLine("Enter path");
                this.DirInfo = Console.ReadLine();
                Console.WriteLine("Current directory  is: {0} \n", DirInfo);
                return DirInfo;
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
                throw;
            }

        }

        //Выводит список папок в директории в сокращенной записи
        public void ShowDir()
        {
            try
            {
                Console.WriteLine("====================================================================");
                Console.WriteLine("The directory {0} contains the following directories: \n", this.DirInfo);
                foreach (var folder in Directory.GetDirectories(this.DirInfo))
                {
                    Console.WriteLine(Path.GetFileName(folder));
                }
                Console.WriteLine("====================================================================");
            }
            catch(Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
                return;
            }
        }
        //Выводит список файлов в ПАПКЕ и их размер без указания пути
        public void ShowFiles()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
                return;
            }
            
        }

        //Выводит список папок с полным путем
        
            public void ShowDirectory()
            {
                try
                {
                    string[] directoryArray = Directory.GetDirectories(DirInfo);
                    foreach (string directory in directoryArray)
                    {
                        Console.WriteLine($"{directory}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.Message);
                    return;
                }
        }
        
        

        //Выводит общий размер папки
        public long GetDirectorySize()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
                throw;
            }

        }
        public void DirSize()
        {
            try
            {
                string[] directoryArray = Directory.GetDirectories(DirInfo);
                foreach (string directory in directoryArray)
                {
                    Console.WriteLine($"{directory}, {directory.Length} bytes");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
                return;
            }

        }
    }
}
