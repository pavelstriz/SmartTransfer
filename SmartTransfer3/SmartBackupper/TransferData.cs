using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartBackupper
{
    public class TransferData
    {
        private MainForm mainForm;
        private ComparePaths comparePaths;
        private ProgressForm progressForm;

        public string[] sourcePaths;
        public string[] destinationPaths;
        public Image img;

        public TransferData(MainForm _mainForm, ProgressForm _progressForm)
        {
            mainForm = _mainForm;
            progressForm = _progressForm;

            
        }
        int indexx = 1;
        
        /*public void TraverseDirectory(DirectoryInfo directoryInfo, string destinationPath)
        {
            var subdirectories = directoryInfo.EnumerateDirectories();

            subFoldersSrc[0] = @"D:\TestFolder";
            foreach (var subdirectory in subdirectories)
            {
                subFoldersSrc[indexx] = subdirectory.FullName;
                MessageBox.Show(subFoldersSrc[indexx]);

                //Directory.CreateDirectory(destinationPath);
                
                TraverseDirectory(subdirectory, null);
                indexx++;
            }


            var files = directoryInfo.EnumerateFiles();

            foreach (var file in files)
            {
                //MessageBox.Show(file.Name);
            }
        }*/


        //C:\Users\Pavel\Documents\TestFolder


        public string[] subFoldersSrc;
        public string[] subFoldersDest;
        int index2;
        int index3;
        int index4;

        public long totalSizeOfAllFiles = 0;
        public int percentageDone = 0;

        public FileStream fsSource;
        public FileStream fsDest;


        int fileCount;
        public void StreamSubFolders(string sourceFolder, string destinationFolder)
        {
            
            index2 = 1;
            index3 = 1;
            index4 = 0;
            fileCount = 0;

            subFoldersSrc = new string[100];
            subFoldersDest = new string[100];

            //BROWSE ALL SOURCE FOLDERS AND SUBFOLDERS
            subFoldersSrc[0] = sourceFolder;
            foreach (string dirPath in Directory.GetDirectories(sourceFolder, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourceFolder, destinationFolder));
                subFoldersSrc[index2] = dirPath;

                //progressForm.progressBar1.Value++;

                index2++;
            }
            //BROWSE ALL DESTINATION FOLDERS AND SUBFOLDERS
            subFoldersDest[0] = destinationFolder;
            foreach (string dirPath in Directory.GetDirectories(destinationFolder, "*", SearchOption.AllDirectories))
            {

                subFoldersDest[index3] = dirPath;
                //MessageBox.Show(subFoldersDest[index3]);

                index3++;
            }
            foreach (string dirPath in subFoldersDest) //BROWSE ARRAY OF SUBFOLDERS
            {
                if (!String.IsNullOrEmpty(subFoldersSrc[index4]))
                {
                    ////MessageBox.Show(s);

                    DirectoryInfo d = new DirectoryInfo(subFoldersSrc[index4]);

                    foreach( var file in d.GetFiles("*"))
                    {
                        totalSizeOfAllFiles += file.Length;
                    }

                    //progressForm.progressBar1.Maximum = (int)totalSizeOfAllFiles;

                    foreach (var file in d.GetFiles("*"))
                    {
                        


                        subFoldersDest[index4] = dirPath;
                        

                        fsSource = new FileStream(file.FullName, FileMode.Open);
                        fsDest = new FileStream(subFoldersDest[index4] + @"\" + file.Name, FileMode.Create);

                        byte[] bt = new byte[1048756];
                        int readByte;

                        while ((readByte = fsSource.Read(bt, 0, bt.Length)) > 0)
                        {
                            fsDest.Write(bt, 0, readByte);

                            //progressForm.progressBar1.Value = (int)(progressForm.progressBar1.Value + file.Length);






                            //progressForm.txtPercentage.Text = progressForm.progressBar1.Value.ToString();

                            

                            /*progressForm.txtPercentage.Invoke((MethodInvoker)delegate {
                                progressForm.txtPercentage.Text = ((int)(int)(fsSource.Position * 100) / fsSource.Length) + "%";
                                
                            });*/


                            /*if (progressForm.worker.WorkerReportsProgress)
                            {
                                int percentComplete = (int)((int)(fsSource.Position * 100) / fsSource.Length);
                                string updateMessage = string.Format("Complete {0}%", percentComplete.ToString());
                                progressForm.worker.ReportProgress(percentComplete, updateMessage);
                                //System.Threading.Thread.Sleep(1000);
                            }*/

                            //progressForm.txtPercentage.Text = ((int)(int)(fsSource.Position * 100) / fsSource.Length).ToString();

                            /*progressForm.txtPercentage.Invoke((MethodInvoker)delegate {
                                progressForm.txtPercentage.Text = ((int)(int)(fsSource.Position * 100) / fsSource.Length) + "Files Converted";
                                
                            });*/
                            //MessageBox.Show(file.Length.ToString());
                            //System.Threading.Thread.Sleep(100);

                        }



                        fsSource.Close();
                        fsDest.Close();

                    }
                    index4++;
                }
            }

        }
        
        public void TransferToDestination(bool scanFolders, bool copyToDestination, DataGridView dgv)
        {
            sourcePaths = new string[mainForm.uC_destination.customListBox1.Items.Count + 1];
            destinationPaths = new string[mainForm.uC_destination.customListBox1.Items.Count + 1];
            //MessageBox.Show(mainForm.uC_destination.customListBox1.Items.Count.ToString());
            if (scanFolders == true)
            {

                //Destination Paths
                int index = 0;
                int rowIndex = 0;
                
                foreach (object listBoxItem2 in mainForm.uC_destination.customListBox1.Items) //DESTINACE
                {
                    index++;
                    destinationPaths[index] = listBoxItem2.ToString();
                    
                    foreach (object listBoxItem in mainForm.uC_Listboxes[0].customListBox1.Items) //ZDROJ
                    {
                        sourcePaths[index] = listBoxItem.ToString();


                        string directoryFolder = System.IO.Path.GetFileName(sourcePaths[index]);

                        

                        if (destinationPaths[index].EndsWith(directoryFolder)) // && POKUD NEBUDE ZA SLOŽKOU \
                        {
                            img = new Icon(Properties.Resources.pbOk3, 1,1).ToBitmap();
                            ((DataGridViewImageCell)dgv.Rows[rowIndex].Cells[1]).Value = img;

                            //ToolTip
                            DataGridViewCell toolTipCell = dgv.Rows[rowIndex].Cells[1];
                            toolTipCell.ToolTipText = "Path does match.";
                            if (copyToDestination == true)
                            {
                                    //TraverseDirectory(d, destinationPaths[index]);


                                StreamSubFolders(sourcePaths[index], destinationPaths[index]);


                                    //StreamFiles(sourcePaths[index], destinationPaths[index]);





                                //Now Create all of the directories
                                /* foreach (string dirPath in Directory.GetDirectories(sourcePaths[index], "*", SearchOption.AllDirectories))
                                 {
                                     Directory.CreateDirectory(dirPath.Replace(sourcePaths[index], destinationPaths[index]));
                                 }

                                 //Copy all the files & Replaces any files with the same name
                                 foreach (string newPath in Directory.GetFiles(sourcePaths[index], "*.*", SearchOption.AllDirectories))
                                 {
                                     File.Copy(newPath, newPath.Replace(sourcePaths[index], destinationPaths[index]), true);
                                     //File

                                 }*/
                            }
                            else if (copyToDestination == false)
                            {
                                //MessageBox.Show("only scan");
                            }
                            break;
                        }
                        else
                        {

                            img = new Icon(Properties.Resources.pbStorno3, 1, 1).ToBitmap();
                            ((DataGridViewImageCell)dgv.Rows[rowIndex].Cells[1]).Value = img;
                            //ToolTip
                            DataGridViewCell toolTipCell = dgv.Rows[rowIndex].Cells[1];
                            toolTipCell.ToolTipText = "Path doesn't match.";

                        }
                    }
                    rowIndex++;
                }
                
            }


        }

    }
}
