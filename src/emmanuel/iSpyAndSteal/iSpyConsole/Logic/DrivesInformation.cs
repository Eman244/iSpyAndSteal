using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpyConsole.Logic
{
    public static class DrivesCompleteInformation
    {

        /// <summary>
        /// Retrieving Drives Information.
        /// </summary>
        /// <returns></returns>
        /// 

        public static List<DrivesInformationClass> GetAllDrivesInformation()
        {
            var drives = DriveInfo.GetDrives();

            List<DrivesInformationClass> list = new List<DrivesInformationClass>();


            foreach (DriveInfo d in drives)
            {
                var drv = new DrivesInformationClass
                {
                    AvailableFreeSpace = d.AvailableFreeSpace,
                    DriveFormat = d.DriveFormat,
                    DriveType = d.DriveType,
                    IsReady = d.IsReady,
                    Name = d.Name,
                    RootDirectory = d.RootDirectory,
                    TotalFreeSpace = ToGB(d.TotalFreeSpace),
                    TotalSize = ToGB(d.TotalSize),
                    VolumeLabel = d.VolumeLabel,
                    UsedSpace = ToGB(d.TotalSize - d.TotalFreeSpace),
                    SerialNo = HardwareInfo.GetHDDSerialNo()
                };
                list.Add(drv);
            }

            return list;
        }

        public static string ToGB(long bytes)
        {
            string[] suffix = new string[] { "B", "KB", "MB", "GB", "TB" };
            float byteNumber = bytes;
            for (int i = 0; i < suffix.Length; i++)
            {
                if (byteNumber < 1000)
                    if (i == 0)
                        return string.Format("{0} {1}", byteNumber, suffix[3]);
                    else
                        return string.Format("{0:0.#0} {1}", byteNumber, suffix[3]);
                else
                    byteNumber /= (1024 * 1024 * 1024);
            }
            string val = string.Format("{0:N} {3}", byteNumber, suffix[suffix.Length - 1]);
            return val;
        }
    }
}
