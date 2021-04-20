using System;
using System.IO;
using System.Collections;

namespace File_Manager
{


    class Program
    {
        //Дает возможность выбрать текущую директорию. Нужно доделывать до рабочего вида, чтобы данные из метода передавались другим
        public static string CurrentDir()
        {
            Console.WriteLine("Enter path");
            string pathString = Console.ReadLine();
            Console.WriteLine("Current directory  is: {0} \n", pathString);
            return pathString;
        }

        //Выводит список папок в директории в сокращенной записи
        public static void ShowDir()
        {
            //Console.WriteLine("Enter path");
            //string pathString = Console.ReadLine();
            string pathString = @"C:\Users\User\Desktop";
            Console.WriteLine("====================================================================");
            Console.WriteLine("The directory {0} contains the following directories: \n", pathString);
            foreach (string folder in Directory.GetDirectories(pathString))
            {
                Console.WriteLine(Path.GetFileName(folder));
            }
            Console.WriteLine("====================================================================");
        }
        //Выводит список файлов в ПАПКЕ и их размер без указания пути
        public static void ShowFiles()
        {
            //Console.WriteLine("Enter path");
            //string pathString = Console.ReadLine();
            string pathString = @"C:\Users\User\Desktop";
            DirectoryInfo directory = new DirectoryInfo(pathString);
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
        static void ShowDirectory()
        {
            string[] directoryArray = Directory.GetDirectories(@"C:\Users\User\Desktop");
            foreach (string directory in directoryArray)
            {

                Console.WriteLine($"{directory}");

            }
        }
        //Выводит общий размер папки
        static long GetDirectorySize(string p)
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
        static void DirSize()
        {
            string[] directoryArray = Directory.GetDirectories(@"C:\Users\User\Desktop\Книги по C#");
            foreach (string directory in directoryArray)
            {
                Console.WriteLine($"{directory}, {directory.Length} bytes");
            }
        }

        //Создание папки в указаной директории
        static void CreateDir()
        {
            Console.WriteLine("Enter path and directory name");
            string pathString = Console.ReadLine();
            try
            {
                Directory.CreateDirectory(pathString);
                Console.WriteLine("Directory Created");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }

        }
        //Научить метод удалять каталог, даже если в нем есть файлы и каталоги
        static void DeleteDir()
        {
            Console.WriteLine("Enter path and directory name you want to be Deleted");
            string pathString = Console.ReadLine();
            Directory.Delete(pathString);
            Console.WriteLine("Directory Deleted");
        }
        //Создание файала по заданному пути и имени
        static void CreateFile()
        {
            Console.WriteLine("Enter path and File name");
            string pathString = Console.ReadLine();
            try
            {
                File.Create(pathString);
                Console.WriteLine("File Created");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }

        }
        //Удаление файла по заданному пути имени
        static void DeleteFile()
        {
            Console.WriteLine("Enter path and File name you want to be Deleted");
            string pathString = Console.ReadLine();
            try
            {
                File.Delete(pathString);
                Console.WriteLine("File Deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }

        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 50);
            Console.SetBufferSize(250, 100);

            
            CurrentDir();
            ShowDir();
            //ShowDirectory();
            ShowFiles();
            DirSize();
            CreateDir();
            CreateFile();
            //DeleteDir();
            DeleteFile();

            Console.WriteLine(GetDirectorySize(@"C:\Users\User\Desktop\Книги по C#"));
 
        }
    }
}
