namespace MyFileManager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.listBoxSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnSelectCopyPath = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCopyFiles = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.chkBoxOverrideExistingFile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Все файлы (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(285, 35);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Выбрать файлы для копирования";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // listBoxSelectedFiles
            // 
            this.listBoxSelectedFiles.FormattingEnabled = true;
            this.listBoxSelectedFiles.Location = new System.Drawing.Point(12, 53);
            this.listBoxSelectedFiles.Name = "listBoxSelectedFiles";
            this.listBoxSelectedFiles.Size = new System.Drawing.Size(728, 95);
            this.listBoxSelectedFiles.TabIndex = 1;
            // 
            // btnSelectCopyPath
            // 
            this.btnSelectCopyPath.Location = new System.Drawing.Point(12, 154);
            this.btnSelectCopyPath.Name = "btnSelectCopyPath";
            this.btnSelectCopyPath.Size = new System.Drawing.Size(285, 34);
            this.btnSelectCopyPath.TabIndex = 2;
            this.btnSelectCopyPath.Text = "Выбрать новое место размещений файлов";
            this.btnSelectCopyPath.UseVisualStyleBackColor = true;
            this.btnSelectCopyPath.Click += new System.EventHandler(this.btnSelectCopyPath_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(12, 194);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(728, 20);
            this.txtDestinationPath.TabIndex = 3;
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.Location = new System.Drawing.Point(12, 220);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Size = new System.Drawing.Size(285, 37);
            this.btnCopyFiles.TabIndex = 4;
            this.btnCopyFiles.Text = "Копировать выбранные файлы";
            this.btnCopyFiles.UseVisualStyleBackColor = true;
            this.btnCopyFiles.Click += new System.EventHandler(this.btnCopyFiles_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(12, 263);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(728, 95);
            this.listBoxResult.TabIndex = 5;
            // 
            // chkBoxOverrideExistingFile
            // 
            this.chkBoxOverrideExistingFile.AutoSize = true;
            this.chkBoxOverrideExistingFile.Location = new System.Drawing.Point(303, 22);
            this.chkBoxOverrideExistingFile.Name = "chkBoxOverrideExistingFile";
            this.chkBoxOverrideExistingFile.Size = new System.Drawing.Size(208, 17);
            this.chkBoxOverrideExistingFile.TabIndex = 6;
            this.chkBoxOverrideExistingFile.Text = "Перезаписать существующий файл";
            this.chkBoxOverrideExistingFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 466);
            this.Controls.Add(this.chkBoxOverrideExistingFile);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnCopyFiles);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.btnSelectCopyPath);
            this.Controls.Add(this.listBoxSelectedFiles);
            this.Controls.Add(this.btnSelectFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.ListBox listBoxSelectedFiles;
        private System.Windows.Forms.Button btnSelectCopyPath;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.CheckBox chkBoxOverrideExistingFile;
    }
}

