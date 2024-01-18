using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Example of File class!");
            try
            {
                string path = @"C:\DotNet-Dec-2023\Messages.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                    Console.WriteLine("File has been created successfully!");
                }
                else
                {
                    //File.WriteAllText(path, "Welcome To India");
                    //File.WriteAllLines(path, new string[] { "Welcome To Delhi", "Welcome To CDAC!" });
                    //File.AppendAllLines(path, new string[] { "Welcome To Delhi", "Welcome To CDAC!" });
                    //File.Copy(path, @"C:\DotNet-Dec-2023\MessagesCopy.txt");
                    File.Delete(@"C:\DotNet-Dec-2023\MessagesCopy.txt");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine("Example of DriveInfo Class!");
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    Console.WriteLine(drive.TotalSize);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine("Example of DriveInfo Class!");
                DirectoryInfo directory=new DirectoryInfo(@"C:\");
                foreach (DirectoryInfo directoryInfo in directory.GetDirectories())
                {
                    Console.WriteLine(directoryInfo.CreationTime);
                }
                //Directory.CreateDirectory("C:\\DotNet-Dec-2023\\Scrap");
                if (Directory.Exists("C:\\DotNet-Dec-2023\\Scrap"))
                {
                    Directory.Delete("C:\\DotNet-Dec-2023\\Scrap");
                }
                Console.WriteLine("Check All files of a given Directory!");
                foreach (string item in Directory.GetDirectories("C:\\DotNet-Dec-2023"))
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            //using (StreamWriter SW = new StreamWriter("C:\\DotNet-Dec-2023\\InfowayLog.txt", true))
            //{
            //    SW.WriteLine("Welcome To India!");
            //    SW.WriteLine("Welcome To Maharashtra!");
            //    SW.WriteLine("Welcome To Pune!");
            //    SW.Close();
            //}
            //using (StreamReader SR=new StreamReader("C:\\DotNet-Dec-2023\\InfowayLog.txt"))
            //{
            //    //Console.WriteLine(SR.ReadToEnd());
            //    while (SR.Peek()!=-1)
            //    {
            //        Console.WriteLine(SR.ReadLine());
            //    }
            //    SR.Close();
            //}
        }
    }
}
