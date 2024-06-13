using System.IO.Enumeration;

namespace Lesson___13._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\abbascb\\Desktop";
            //Directory.CreateDirectory(path + "\\Drctry");
            //Directory.CreateDirectory(path + "\\Drctry" + "\\Directory1");
            //Directory.CreateDirectory(path + "\\Drctry" + "\\Directory2");
            //File.CreateText(path + "\\Drctry" + "\\Directory1" + "\\file1.txt");
            //File.CreateText(path + "\\Drctry" + "\\Directory2" + "\\file2.txt");

            List<string> list1 = new List<string>() { "Salam" };
            //File.AppendAllLines(path + "\\Drctry" + "\\Directory1" + "\\file1.txt", list1);

            List<string> list2 = new List<string>() { "Sagol" };
            //File.AppendAllLines(path + "\\Drctry" + "\\Directory2" + "\\file2.txt", list2);


            DirectoryInfo directoryInfo= new DirectoryInfo(path);

            foreach (var item in directoryInfo.GetDirectories())
            {
                foreach (var item2 in directoryInfo.GetFiles())
                { 

                }
            }


        }
    }
}