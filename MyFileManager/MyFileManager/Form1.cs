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
        List<string> _copiedFiles;
        public Form1()
        {
            InitializeComponent();
            MyInitializeComponets();
        }

        private void MyInitializeComponets()
        {
            _copiedFiles = new List<string>();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                listBoxSelectedFiles.Items.Clear();
                foreach (var file in openFileDialog1.FileNames)
                    listBoxSelectedFiles.Items.Add(file);
            }
            
        }

        private void btnSelectCopyPath_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinationPath.Text = folderBrowserDialog1.SelectedPath;
            }
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

        private void CopyFile()
        {
            string targetPath = txtDestinationPath.Text;

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            foreach(string path in listBoxSelectedFiles.Items)
            {
                string fileName = Path.GetFileName(path);
                string result = "";
                listBoxResult.Items.Add(fileName);
                string newFilePath = Path.Combine(txtDestinationPath.Text, fileName);
                listBoxResult.Items.Add(newFilePath);
                try
                {
                    File.Copy(path, newFilePath,chkBoxOverrideExistingFile.Checked);
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
                            _copiedFiles.Add(path);
                        }
                        else
                            result = "File not copy!";
                    }
                        
                    result = string.Format("{0}: {1}", newFilePath, result);
                    listBoxResult.Items.Add(result);
                }
            }
            foreach(string file in _copiedFiles)
            {
                listBoxSelectedFiles.Items.Remove(file);
            }
            _copiedFiles.Clear();
        }
    }
}
