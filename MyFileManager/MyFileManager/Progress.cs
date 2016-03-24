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
        private MyEngine _engine;
        private DateTime _startTime;

        public Progress(MyEngine engine)
        {
            InitializeComponent();

            _engine = engine;
            MyInitializeComponent();
        }
        private void MyInitializeComponent()
        {
            SetPBTotalFiles(0);
            
        }
        private void SetPBTotalFiles(int value = -1)
        {
            if (value == -1)
            {
                if (progressBarTotalFiles.Value < progressBarTotalFiles.Maximum)
                {
                    progressBarTotalFiles.Value++;
                }
            }
            else
            {
                progressBarTotalFiles.Value = value;
                progressBarTotalFiles.Maximum = _engine.SourceFiles.Count;
            }
                
            labelTotal.Text = string.Format("Обработано {0} из {1} файлов", progressBarTotalFiles.Value, progressBarTotalFiles.Maximum);
        }

        private void SetCurrentFileInfo(FileInfo file)
        {
            labelCurrentFile.Text = string.Format("Файл: {0} Размер: {1} kB",file.Name,file.Length/1024);
        }
        CopyFileCallbackAction myCallback(FileInfo source, FileInfo destination, object state, long totalFileSize, long totalBytesTransferred)
        {
            double dProgress = (totalBytesTransferred / (double)totalFileSize) * 100.0;
            progressBarCurrentFile.Value = (int)dProgress;
            return CopyFileCallbackAction.Continue;
        }

        private void SetTotalTime(string sec)
        {
            labelTotalTime.Text = string.Format("Общее время копирования: {0} секунд",sec);
        }

        public void Copy()
        {
            _startTime = DateTime.Now;
            foreach(var file in _engine.SourceFiles)
            {
                //file.CopyTo(Path.Combine(_targetFolder,file.Name),true);
                //FileRoutines.CopyFile(new FileInfo("source.txt"), new FileInfo("dest.txt"), myCallback);
                //Task.Run(() => FileRoutines.CopyFile(file,new FileInfo(Path.Combine(_targetFolder, file.Name)),CopyFileOptions.None));//,myCallback));
                try
                {
                    SetCurrentFileInfo(file);
                    //статический метод копирования который нужно доработать на больших файлах просто блокирует GUI
                    FileRoutines.CopyFile(file, new FileInfo(Path.Combine(_engine.TargetFolder, file.Name)), CopyFileOptions.None, myCallback);
                    
                    SetPBTotalFiles();
                    SetTotalTime((DateTime.Now - _startTime).TotalSeconds.ToString());
                    _engine.ProcessedFiles.Add(file);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            foreach(var file in _engine.ProcessedFiles)
            {
                _engine.SourceFiles.Remove(file);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
