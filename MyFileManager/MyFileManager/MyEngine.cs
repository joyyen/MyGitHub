using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MyFileManager
{
    /// <summary>
    /// класс реализующий основную логику программы
    /// </summary>
    public class MyEngine
    {
        /// <summary>
        /// список файлов
        /// </summary>
        private List<FileInfo> _sourceFiles;

        /// <summary>
        /// свойство список файлов
        /// </summary>
        public List<FileInfo> SourceFiles 
        {
            get
            {
                return _sourceFiles;
            }
            set
            {
                _sourceFiles = value;
            }
        }
        private List<FileInfo> _processedFiles;

        public List<FileInfo> ProcessedFiles
        {
            get
            {
                return _processedFiles;
            }
            set
            {
                _processedFiles = value;
            }
        }

        /// <summary>
        /// целевой каталог
        /// </summary>
        private string _targetFolder;

        /// <summary>
        /// свойство целевой каталог
        /// </summary>
        public string TargetFolder 
        { 
            get
            {
                return _targetFolder;
            }
            set
            {
                _targetFolder = value;
            }
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public MyEngine()
        {
            SourceFiles = new List<FileInfo>();
            ProcessedFiles = new List<FileInfo>();
            TargetFolder = "";
        }

        /// <summary>
        /// выбор файлов для обработки
        /// </summary>
        public void GetFiles(OpenFileDialog ofd)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    _sourceFiles.Add(new FileInfo(fileName));
                }
            }
        }
        /// <summary>
        /// выбор целевого каталога
        /// </summary>
        public void GetTargetFolder(FolderBrowserDialog fbd)
        {
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _targetFolder = fbd.SelectedPath;
            }
        }
        /// <summary>
        /// вывод списка файлов
        /// </summary>
        public void ShowSourceFiles(ListBox lb)
        {
            ShowFiles(lb, SourceFiles);
        }
        public void ShowProcessedFiles(ListBox lb)
        {
            ShowFiles(lb, ProcessedFiles);
        }
        public void ShowFiles(ListBox lb, List<FileInfo> list)
        {
            lb.Items.Clear();
            foreach (FileInfo file in list)
            {
                lb.Items.Add(file.FullName);
            }
        }
    }
}
