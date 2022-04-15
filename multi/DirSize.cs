using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Data;

namespace multi
{
    class DirSize
    {
        static void Main(string[] args)
        {
            //10 threads in total
            List<int> integerList = Enumerable.Range(0, 10).ToList();
            string path = @"C:\Users\admin\Desktop\Daily Report";
            Parallel.ForEach(integerList, i =>
            {
                double size = GetDirectorySizeInMB(path);
                Console.WriteLine(@"The size of this file is {0} KB, and the value of thread = {1}.", size, Thread.CurrentThread.ManagedThreadId);
            });
            Console.WriteLine("Press any key to exist:");
            Console.ReadLine();
        }

        static double GetDirectorySizeInMB(string directoryPath)
        {
            DirectoryInfo dir = new DirectoryInfo(directoryPath);
            double dirSize = 0;
            foreach (FileInfo file in dir.GetFiles())
            {
                dirSize += Math.Round(file.Length / 1024.00, 2);
            }
            return dirSize;
        }
    }
}





//basic code
/*List<int> integerList = Enumerable.Range(0, 10).ToList();
Parallel.ForEach(integerList, i =>
{
    Console.WriteLine(@"value of i = {0}, thread = {1}", i, Thread.CurrentThread.ManagedThreadId);
});

Console.WriteLine("Press any key to exist:");
Console.ReadLine();*/

/*string path = @"C:\Users\admin\Desktop\Daily Report\Daily Report 4-13.pdf";
double size = GetDirectorySizeInMB(path);
Console.WriteLine(@"The size of this file is {0} KB.", size);
Console.ReadLine();*/
