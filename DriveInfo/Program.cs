using System;
using System.IO;

namespace DriveInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (var drive in driveInfos)
            {
                Console.WriteLine("Name : " + drive.Name);
                Console.WriteLine("Total Size : " + drive.TotalSize);

                Console.WriteLine("Total Free Space : " + drive.TotalFreeSpace);
                Console.WriteLine("Drive Type : " + drive.DriveType);

                Console.WriteLine("Volume Label : " + drive.DriveType);
                Console.WriteLine("Root Directory : " + drive.RootDirectory);
                Console.WriteLine("Drive Format : " + drive.DriveFormat);
            }
        }
    }
}
