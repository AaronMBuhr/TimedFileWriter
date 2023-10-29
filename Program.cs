using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedFileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ln = 1;
            bool quit = false;
            using (StreamWriter sw = File.AppendText("c:\\temp\\testshared.txt"))
            {
                //sw.Write("this is going to be a non-terminated line");
                while (ln < 300)
                {
                    Console.WriteLine("Line " + ln);
                    sw.WriteLine("Line " + ln++);
                    sw.Flush();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
