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
        public Form1()
        {
            InitializeComponent();
            MyInitializeComponets();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            Engine.GetFiles(openFileDialog1);
            Engine.ShowSourceFiles(listBoxSelectedFiles);

        }

        private void btnSelectCopyPath_Click(object sender, EventArgs e)
        {
            Engine.GetTargetFolder(folderBrowserDialog1);
            txtDestinationPath.Text = Engine.TargetFolder;
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

       
        
    }
}
