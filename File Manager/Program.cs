using System;
using System.IO;
using System.Collections;

namespace File_Manager
{


    class Program
    {

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
                return;
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
                return;
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
                return;
            }

            static void Main(string[] args)
            {
                Console.SetWindowSize(200, 50);
                Console.SetBufferSize(250, 100);


                var Info = new ShowInfo();
                Info.CurrentDir();
                Info.ShowDir();
                Info.ShowFiles();
                Info.DirSize();
                Info.ShowDirectory();
                Info.GetDirectorySize();


                //CreateDir();
                //CreateFile();
                ////DeleteDir();
                //DeleteFile();

            //Console.WriteLine(GetDirectorySize(@"C:\Users\User\Desktop\Книги по C#"));

            }
        
    }
}
