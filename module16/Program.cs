using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module16
{
class FileManager
    {
        static void Main(string[] args)
        {
            bool running = true;
            string logPath = "log.txt";

            while (running)
            {
                Console.WriteLine("\nПростой Файловый Менеджер");
                Console.WriteLine("1. Просмотр содержимого директории");
                Console.WriteLine("2. Создать файл/директорию");
                Console.WriteLine("3. Удалить файл/директорию");
                Console.WriteLine("4. Копировать/переместить файл/директорию");
                Console.WriteLine("5. Чтение и запись в файл");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ViewDirectoryContents();
                        break;
                    case "2":
                        CreateFileOrDirectory();
                        break;
                    case "3":
                        DeleteFileOrDirectory();
                        break;
                    case "4":
                        CopyOrMoveFileOrDirectory();
                        break;
                    case "5":
                        ReadWriteFile();
                        break;
                    case "0":
                        running = false;
                        break;
                }
            }

            void LogAction(string action)
            {
                File.AppendAllText(logPath, $"{DateTime.Now}: {action}\n");
            }

            void ViewDirectoryContents()
            {
                Console.Write("Введите путь к директории: ");
                string path = Console.ReadLine();

                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path);
                    string[] directories = Directory.GetDirectories(path);

                    Console.WriteLine("\nФайлы:");
                    foreach (var file in files)
                    {
                        Console.WriteLine(file);
                    }

                    Console.WriteLine("\nДиректории:");
                    foreach (var dir in directories)
                    {
                        Console.WriteLine(dir);
                    }
                }
                else
                {
                    Console.WriteLine("Директория не найдена.");
                }

                LogAction($"Просмотр содержимого директории: {path}");
            }

            // Остальные функции (CreateFileOrDirectory, DeleteFileOrDirectory, CopyOrMoveFileOrDirectory, ReadWriteFile) должны быть реализованы аналогично
        }

        private static void ReadWriteFile()
        {
            throw new NotImplementedException();
        }

        private static void CopyOrMoveFileOrDirectory()
        {
            throw new NotImplementedException();
        }

        private static void DeleteFileOrDirectory()
        {
            throw new NotImplementedException();
        }

        private static void CreateFileOrDirectory()
        {
            throw new NotImplementedException();
        }
    }

}

