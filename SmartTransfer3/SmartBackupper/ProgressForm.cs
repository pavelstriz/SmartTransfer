using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartBackupper
{
    public partial class ProgressForm : Form
    {
        private MainForm mainForm;



        public TransferData transferDataMethod;
        public BackgroundWorker worker;
        private DataGridView datagridview;
        public ProgressForm(MainForm _mainForm, DataGridView _dataGridView)
        {
            InitializeComponent();

            mainForm = _mainForm;
            datagridview = _dataGridView;

            transferDataMethod = new TransferData(mainForm, this);
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;

        }
        public string[] workerResult;

        public string[] sourcePaths;
        public string[] destinationPaths;

        public string[] subFoldersSrc;
        public string[] subFoldersDest;
        int index2;
        int index3;
        int index4;

        public long totalSizeOfAllFiles = 0;
        public int percentageDone = 0;

        public FileStream fsSource;
        public FileStream fsDest;
        public int filesMax = 0;
        public int filesEach = 0;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        private string speed;
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            sourcePaths = new string[mainForm.uC_destination.customListBox1.Items.Count + 1];
            destinationPaths = new string[mainForm.uC_destination.customListBox1.Items.Count + 1];
            //MessageBox.Show(mainForm.uC_destination.customListBox1.Items.Count.ToString());

            //Destination Paths
            int index = 0;
            

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
                        //KOPÍROVÁNÍ SOUBORŮ
                        //transferDataMethod.StreamSubFolders(sourcePaths[index], destinationPaths[index]);
                        
                        index2 = 1;
                        index3 = 1;
                        index4 = 0;

                        subFoldersSrc = new string[100];
                        subFoldersDest = new string[100];

                        //BROWSE ALL SOURCE FOLDERS AND SUBFOLDERS
                        subFoldersSrc[0] = sourcePaths[index];
                        foreach (string dirPath in Directory.GetDirectories(sourcePaths[index], "*", SearchOption.AllDirectories))
                        {
                            Directory.CreateDirectory(dirPath.Replace(sourcePaths[index], destinationPaths[index]));
                            subFoldersSrc[index2] = dirPath;


                            index2++;
                        }
                        //BROWSE ALL DESTINATION FOLDERS AND SUBFOLDERS
                        subFoldersDest[0] = destinationPaths[index];
                        foreach (string dirPath in Directory.GetDirectories(destinationPaths[index], "*", SearchOption.AllDirectories))
                        {
                            subFoldersDest[index3] = dirPath;
                            //MessageBox.Show(subFoldersDest[index3]);

                            index3++;
                        }

                        
                        foreach (string dirPath in subFoldersDest) //BROWSE ARRAY OF SUBFOLDERS
                        {
                            if (!String.IsNullOrEmpty(subFoldersSrc[index4]))
                            {
                                DirectoryInfo d = new DirectoryInfo(subFoldersSrc[index4]);
                                sw.Start();
                                double elapsedSec = 0.0;
                                
                                foreach (var file in d.GetFiles("*"))
                                {
                                    
                                    
                                    subFoldersDest[index4] = dirPath;


                                    fsSource = new FileStream(file.FullName, FileMode.Open);
                                    fsDest = new FileStream(subFoldersDest[index4] + @"\" + file.Name, FileMode.Create);
                                    byte[] bt = new byte[1048756];
                                    int readByte;

                                    readByte = fsSource.Read(bt, 0, bt.Length);
                                    //while ((readByte = fsSource.Read(bt, 0, bt.Length)) > 0)
                                   // {
                                    fsDest.Write(bt, 0, readByte);

                                    if (sw.Elapsed.TotalSeconds != 0)
                                        elapsedSec = Convert.ToInt32(sw.Elapsed.TotalSeconds);


                                    if (elapsedSec > 0.0)
                                        speed = Math.Round(Convert.ToInt32(file.Length / 1024) / elapsedSec, 2).ToString();


                                    workerResult[0] = file.Name;
                                    workerResult[1] = String.Format("Copying files.. ({0}/{1})", filesEach + 1, filesMax);
                                    workerResult[2] = speed + " KB/s";
                                    //workerResult[2] = ((Convert.ToInt32(file.Length / 1024) / elapsedSec)).ToString();
                                    filesEach++;
                                    worker.ReportProgress((filesEach * 100) / filesMax, workerResult);
                                    System.Threading.Thread.Sleep(100);
                                    


                                    fsSource.Close();
                                    fsDest.Close();

                                }
                                sw.Stop();
                                index4++;
                            }
                        }
                        
                    }
                }
            }

            worker.CancelAsync();


        }



        int index = 0;
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;
            txtPercentage.Text = e.ProgressPercentage.ToString() + "%";

            string[] progressLabels = (string[])e.UserState;
            txtFilePaths.Text = progressLabels[0];
            txtOfMax.Text = progressLabels[1];
            txtCopySpeed.Text = progressLabels[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            GetMaximumFilesCountAndInfo();
            worker.RunWorkerAsync();
            
        }
        
        private void GetMaximumFilesCountAndInfo()
        {

            sourcePaths = new string[mainForm.uC_destination.customListBox1.Items.Count + 1];
            destinationPaths = new string[mainForm.uC_destination.customListBox1.Items.Count + 1];
           
            int index = 0;


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

                        index2 = 1;
                        index3 = 1;
                        index4 = 0;

                        subFoldersSrc = new string[100];
                        subFoldersDest = new string[100];

                        //BROWSE ALL SOURCE FOLDERS AND SUBFOLDERS
                        subFoldersSrc[0] = sourcePaths[index];
                        foreach (string dirPath in Directory.GetDirectories(sourcePaths[index], "*", SearchOption.AllDirectories))
                        {
                            Directory.CreateDirectory(dirPath.Replace(sourcePaths[index], destinationPaths[index]));
                            subFoldersSrc[index2] = dirPath;


                            index2++;
                        }
                        //BROWSE ALL DESTINATION FOLDERS AND SUBFOLDERS
                        subFoldersDest[0] = destinationPaths[index];
                        foreach (string dirPath in Directory.GetDirectories(destinationPaths[index], "*", SearchOption.AllDirectories))
                        {
                            subFoldersDest[index3] = dirPath;
                            //MessageBox.Show(subFoldersDest[index3]);

                            index3++;
                        }


                        foreach (string dirPath in subFoldersDest) //BROWSE ARRAY OF SUBFOLDERS
                        {

                            if (!String.IsNullOrEmpty(subFoldersSrc[index4]))
                            {
                                DirectoryInfo d = new DirectoryInfo(subFoldersSrc[index4]);
                                foreach (var file in d.GetFiles("*"))
                                {
                                    filesMax++;
                                    workerResult = new string[filesMax];
                                    //MessageBox.Show(filesMax.ToString());
                                }
                                index4++;
                            }
                        }
                    }
                }
            }
        }
    }
}
