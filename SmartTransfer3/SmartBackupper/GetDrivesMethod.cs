using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackupper
{
    public class GetDrivesMethod
    {
        private MainForm mainForm;
        public GetDrivesMethod(MainForm _mainForm)
        {
            mainForm = _mainForm;
        }

        public string FormatBytes(long bytes, long totalBytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;

            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            string[] Suffix2 = { "B", "KB", "MB", "GB", "TB" };
            int j;
            double dblSByte2 = totalBytes;
            for (j = 0; j < Suffix2.Length && totalBytes >= 1024; j++, totalBytes /= 1024)
            {
                dblSByte2 = totalBytes / 1024.0;
            }

            //return String.Format
            return String.Format("{0:0.##} / ", dblSByte) + String.Format("{0:0.##} {1}", dblSByte2, Suffix2[i]);
        }

        public struct DiskInfo
        {
            public string VolumeLabel;
            public string Name;
            public string DriveFormat;
            public long TotalFreeSize;
            public long TotalSize;
        }
        public DiskInfo[] diskInfos = new DiskInfo[10];
        int i = 0;
        public void LoadExternalDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable || drive.DriveType == DriveType.Fixed)
                {
                    i++;
                    diskInfos[i].Name = drive.Name;
                    diskInfos[i].VolumeLabel = drive.VolumeLabel;
                    diskInfos[i].DriveFormat = drive.DriveFormat;

                    diskInfos[i].TotalFreeSize = drive.TotalFreeSpace;
                    diskInfos[i].TotalSize = drive.TotalSize;


                    if (drive.Name != "C:\\")
                    {
                        
                        //External drive
                        mainForm.cbExternalDrive.Items.Add(diskInfos[i].Name + diskInfos[i].VolumeLabel + " (" + diskInfos[i].DriveFormat + ")");
                        mainForm.cbExternalDrive.Text = mainForm.cbExternalDrive.Items[0].ToString();
                        mainForm.cbExternalDrive.SelectedItem = false;
                        //mainForm.cbExternalDrive.Items.RemoveAt(0);
                    }
                    //Destination drive
                    mainForm.cbDestinationDrive.Items.Add(diskInfos[i].Name + diskInfos[i].VolumeLabel + " (" + diskInfos[i].DriveFormat + ")");
                    mainForm.cbDestinationDrive.Text = mainForm.cbDestinationDrive.Items[0].ToString();
                    mainForm.cbDestinationDrive.SelectedItem = false;
                  


                }
            }




        }
    }
}
