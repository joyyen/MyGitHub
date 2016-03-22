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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBarTotalFiles = new System.Windows.Forms.ProgressBar();
            this.progressBarCurrentFile = new System.Windows.Forms.ProgressBar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(219, 190);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 39);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Остановить копирование";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBarTotalFiles
            // 
            this.progressBarTotalFiles.Location = new System.Drawing.Point(28, 37);
            this.progressBarTotalFiles.Name = "progressBarTotalFiles";
            this.progressBarTotalFiles.Size = new System.Drawing.Size(430, 35);
            this.progressBarTotalFiles.TabIndex = 2;
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
            this.labelTotal.Location = new System.Drawing.Point(25, 21);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 254);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.progressBarCurrentFile);
            this.Controls.Add(this.progressBarTotalFiles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStop);
            this.Name = "Progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBarTotalFiles;
        private System.Windows.Forms.ProgressBar progressBarCurrentFile;
        private System.Windows.Forms.Label labelTotal;
    }
}