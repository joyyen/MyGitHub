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
    public partial class Form1 : Form
    {
        private List<FileInfo> _files;
        string _target;

        public Form1()
        {
            InitializeComponent();
            MyInitializeComponets();
        }

        private void MyInitializeComponets()
        {
            _files = new List<FileInfo>();
            _target = "";
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            SelectSource();
            ShowFiles();
        }

        private void btnSelectCopyPath_Click(object sender, EventArgs e)
        {
            SelectTarget();
        }

        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            try
            {
                CopyFile();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void SelectSource()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    _files.Add(new FileInfo(fileName));
                }
            }
        }

        public void SelectTarget()
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _target = folderBrowserDialog1.SelectedPath;
                txtDestinationPath.Text = _target;
                
            }
        }

        private void ShowFiles()
        {
            foreach(FileInfo file in _files)
            {
                listBoxSelectedFiles.Items.Add(file.FullName);
            }
            
        }

        private async void CopyFileAsync(string source, string destination)
        {
            using (FileStream SourceStream = File.Open(source, FileMode.Open))
            {
                using (FileStream DestinationStream = File.Create(destination))
                {
                    await SourceStream.CopyToAsync(DestinationStream);
                }
            }
        }
        private void CopyFile()

        {
            if (listBoxSelectedFiles.Items.Count == 0)
            {
                SelectSource();
                ShowFiles();

                if (_files.Count == 0)
                {
                    throw new ArgumentNullException("No selected files!");
                }
            }
                    
            if(string.IsNullOrEmpty(txtDestinationPath.Text.Trim()))
            {
                SelectTarget();

                if (string.IsNullOrEmpty(_target))
                {
                    throw new ArgumentNullException("No selected target path!");
                }
            }

            if (!Directory.Exists(_target))
            {
                Directory.CreateDirectory(_target);
            }

            Progress form = new Progress(_files, _target);
            try
            {
                form.Copy();
                form.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                form.Dispose();
            }

            /*
            foreach(string path in listBoxSelectedFiles.Items)
            {
                string fileName = Path.GetFileName(path);
                string result = "";
                listBoxResult.Items.Add(fileName);
                string newFilePath = Path.Combine(txtDestinationPath.Text, fileName);
                listBoxResult.Items.Add(newFilePath);
                try
                {
                    //File.Copy(path, newFilePath,chkBoxOverrideExistingFile.Checked);
                    CopyFileAsync(path, newFilePath);
                }
                catch(Exception ex)
                {
                    result = ex.Message;
                }
                finally
                {
                    if(string.IsNullOrEmpty(result))
                    {
                        if (File.Exists(newFilePath))
                        {
                            result = "OK";
                            //_copiedFiles.Add(path);
                        }
                        else
                            result = "File not copy!";
                    }
                        
                    result = string.Format("{0}: {1}", newFilePath, result);
                    listBoxResult.Items.Add(result);
                }
            }*/
            /*foreach(string file in _copiedFiles)
            {
                listBoxSelectedFiles.Items.Remove(file);
            }
            _copiedFiles.Clear();*/
        }
    }
}
