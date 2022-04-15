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
    class CopyDir
    {
        static void Main(string[] args)
        {
            string sp = @"C:\Users\admin\Desktop\Study\";
            string dp = @"C:\Users\admin\Desktop\Use\newStudy\";
            CopyDirectory(sp, dp, false);
            Console.WriteLine("Cpoy Directory is ok.");
            Console.ReadLine();
        }

        static void CopyDirectory(string sourceDirectory, string targetDirectory, bool overwriteExistingFiles)
        {
            if (Directory.Exists(sourceDirectory))
            {
                if (Directory.Exists(targetDirectory)==false)
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                foreach (string file in Directory.GetFiles(sourceDirectory))
                {
                    FileInfo File = new FileInfo(file);
                    File.CopyTo(targetDirectory + File.Name, overwriteExistingFiles);
                }
            }
        }
    }
}
