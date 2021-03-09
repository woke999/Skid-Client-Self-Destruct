//change your directory to the director of your client files
//the reason this is a thing is because if staff want to check your files or some gay shit
using System;
using System.IO;

namespace Skid_Client_Self_Destruct
{
    class SelfDestruct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to self destruct");
            Console.Title = "Skid Client Self Destruct";
            Console.Read();
            System.IO.DirectoryInfo di = new DirectoryInfo("C:/Users/Woke/source/repos/Skid Client/Skid Client Self Destruct/bin/Debug/netcoreapp3.1/Delete Files");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
