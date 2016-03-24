namespace MyFileManager
{
    partial class Progress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBarTotalFiles = new System.Windows.Forms.ProgressBar();
            this.progressBarCurrentFile = new System.Windows.Forms.ProgressBar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.myEngineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTotalTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myEngineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(218, 253);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 39);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Остановить копирование";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBarTotalFiles
            // 
            this.progressBarTotalFiles.Location = new System.Drawing.Point(28, 44);
            this.progressBarTotalFiles.Name = "progressBarTotalFiles";
            this.progressBarTotalFiles.Size = new System.Drawing.Size(430, 35);
            this.progressBarTotalFiles.Step = 1;
            this.progressBarTotalFiles.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTotalFiles.TabIndex = 2;
            this.progressBarTotalFiles.Tag = "";
            // 
            // progressBarCurrentFile
            // 
            this.progressBarCurrentFile.Location = new System.Drawing.Point(28, 119);
            this.progressBarCurrentFile.Name = "progressBarCurrentFile";
            this.progressBarCurrentFile.Size = new System.Drawing.Size(430, 39);
            this.progressBarCurrentFile.TabIndex = 3;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Location = new System.Drawing.Point(25, 19);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total";
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentFile.Location = new System.Drawing.Point(25, 94);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(23, 13);
            this.labelCurrentFile.TabIndex = 5;
            this.labelCurrentFile.Text = "File";
            // 
            // myEngineBindingSource
            // 
            this.myEngineBindingSource.DataSource = typeof(MyFileManager.MyEngine);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(MyFileManager.Form1);
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalTime.Location = new System.Drawing.Point(25, 170);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(30, 13);
            this.labelTotalTime.TabIndex = 6;
            this.labelTotalTime.Text = "Time";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 325);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.progressBarCurrentFile);
            this.Controls.Add(this.progressBarTotalFiles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStop);
            this.Name = "Progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress";
            ((System.ComponentModel.ISupportInitialize)(this.myEngineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBarTotalFiles;
        private System.Windows.Forms.ProgressBar progressBarCurrentFile;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource myEngineBindingSource;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.Label labelTotalTime;
    }
}