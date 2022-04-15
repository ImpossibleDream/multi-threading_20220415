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
    class RanSample
    {
        static void Main(string[] args)
        {
            //List<int> integerList = Enumerable.Range(0,1).ToList();
            string path = @"C:\Users\admin\Desktop\Study\recall.txt";
            
            //Parallel.ForEach(integerList,i =>
            //{
                Random x = new Random();
                int count = x.Next(0,readLine(path));
                for (int l = count; l > 0; l--)
                {
                    Console.WriteLine(@"The {0}th line is: {1}", count, RandomSample(path, count));
                }
            //});
            Console.WriteLine("Press any key to exist:");
            Console.ReadLine();
        }

        static string RandomSample(string filePath, int n)
        {
            //StreamReader file = new StreamReader(filePath);
            string[] line = File.ReadAllLines(filePath);

            //Random x = new Random();
            //int count = x.Next(0, readLine(filePath));

            return line[n];
        }

        public static int readLine(string path)
        {
            int ll = 0;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            while (sr.ReadLine()!=null)
            {
                ll++;
            }
            fs.Close();
            sr.Close();

            return ll;
        }
    }
}
