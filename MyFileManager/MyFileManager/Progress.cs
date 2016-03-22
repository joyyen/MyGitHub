using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyFileManager
{
    public partial class Progress : Form
    {
        private List<FileInfo> _files;
        private string _target;

        /*public Progress()
        {
            InitializeComponent();
        }*/
        public Progress(List<FileInfo> list, string target)
        {
            InitializeComponent();
            
            _files = list;
            _target = target;

            MyInitializeComponent();
        }
        private void MyInitializeComponent()
        {
            progressBarTotalFiles.Maximum = _files.Count;
            labelTotal.Text = string.Format("Обработано {0} из {1} файлов", 0, _files.Count);
        }

        CopyFileCallbackAction myCallback(FileInfo source, FileInfo destination, object state, long totalFileSize, long totalBytesTransferred)
        {
            double dProgress = (totalBytesTransferred / (double)totalFileSize) * 100.0;
            progressBarCurrentFile.Value = (int)dProgress;
            return CopyFileCallbackAction.Continue;
        }

        public void Copy()
        {
            progressBarTotalFiles.Value = 0;
            foreach(var file in _files)
            {
                //file.CopyTo(Path.Combine(_target,file.Name),true);
                //FileRoutines.CopyFile(new FileInfo("source.txt"), new FileInfo("dest.txt"), myCallback);
                
               
                //Task.Run(() => FileRoutines.CopyFile(file,new FileInfo(Path.Combine(_target, file.Name)),CopyFileOptions.None));//,myCallback));
                FileRoutines.CopyFile(file,new FileInfo(Path.Combine(_target, file.Name)),CopyFileOptions.None, myCallback); 

                progressBarTotalFiles.Value ++;
                labelTotal.Text = string.Format("Обработано {0} из {1} файлов", progressBarTotalFiles.Value, _files.Count);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
