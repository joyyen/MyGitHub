using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MyFileManager
{
    public partial class Form1
    {
        /// <summary>
        /// объект класса, реализующего основную логику программы
        /// </summary>
        private MyEngine _engine;

        /// <summary>
        /// свойство отображающее объект основго класса, реализующего логику программы
        /// </summary>
        public MyEngine Engine
        {
            get
            {
                return _engine;
            }
        }

        /// <summary>
        /// инициализатор пользовательских элементов (выделенный метод входящий в конструктор)
        /// </summary>
        private void MyInitializeComponets()
        {
            _engine = new MyEngine();
        }


        
        /// <summary>
        /// копирование файла в асинхронном режиме
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /*private async void CopyFileAsync(string source, string destination)
        {
            using (FileStream SourceStream = File.Open(source, FileMode.Open))
            {
                using (FileStream DestinationStream = File.Create(destination))
                {
                    await SourceStream.CopyToAsync(DestinationStream);
                }
            }
        }*/
        /// <summary>
        /// предподготовка исходных данных
        /// список файлов для обработки
        /// целевой каталог
        /// </summary>
        private bool Pretreatment()
        {
            if (Engine.SourceFiles.Count == 0)
            {
                Engine.GetFiles(openFileDialog1);
                Engine.ShowSourceFiles(listBoxSelectedFiles);

                if (Engine.SourceFiles.Count == 0)
                {
                    MessageBox.Show("Нет файлов для обработки!");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(Engine.TargetFolder))
            {
                Engine.GetTargetFolder(folderBrowserDialog1);
                txtDestinationPath.Text = Engine.TargetFolder;

                if (string.IsNullOrEmpty(Engine.TargetFolder))
                {
                    MessageBox.Show("Не выбран целевой каталог!");
                    return false;
                }
            }

            if (!Directory.Exists(Engine.TargetFolder))
            {
                Directory.CreateDirectory(Engine.TargetFolder);
            }
            
            return true;
        }

        private void CopyFile()
        {
            if (!Pretreatment()) 
                return;
            

            Progress form = new Progress(Engine);
            try
            {
                form.Copy();
                form.ShowDialog();
                Engine.ShowSourceFiles(listBoxSelectedFiles);
                Engine.ShowProcessedFiles(listBoxResult);
            }
            catch (Exception ex)
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
