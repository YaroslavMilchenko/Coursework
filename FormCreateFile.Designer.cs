namespace Coursework
{
    partial class FormCreateFile
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
            this.FileName = new System.Windows.Forms.TextBox();
            this.FileDirectory = new System.Windows.Forms.TextBox();
            this.SearchDirectoryToCreate = new System.Windows.Forms.PictureBox();
            this.CreateButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDirectoryToCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.FileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileName.Font = new System.Drawing.Font("Times New Roman", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(23, 115);
            this.FileName.Multiline = true;
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(1024, 78);
            this.FileName.TabIndex = 1;
            // 
            // FileDirectory
            // 
            this.FileDirectory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.FileDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDirectory.Font = new System.Drawing.Font("Times New Roman", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileDirectory.Location = new System.Drawing.Point(23, 370);
            this.FileDirectory.Multiline = true;
            this.FileDirectory.Name = "FileDirectory";
            this.FileDirectory.Size = new System.Drawing.Size(1024, 78);
            this.FileDirectory.TabIndex = 2;
            // 
            // SearchDirectoryToCreate
            // 
            this.SearchDirectoryToCreate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SearchDirectoryToCreate.Image = global::Coursework.Properties.Resources.Folder70x70;
            this.SearchDirectoryToCreate.Location = new System.Drawing.Point(968, 374);
            this.SearchDirectoryToCreate.Name = "SearchDirectoryToCreate";
            this.SearchDirectoryToCreate.Size = new System.Drawing.Size(70, 70);
            this.SearchDirectoryToCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchDirectoryToCreate.TabIndex = 4;
            this.SearchDirectoryToCreate.TabStop = false;
            this.SearchDirectoryToCreate.Click += new System.EventHandler(this.SearchDirectoryToCreate_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Image = global::Coursework.Properties.Resources.Створити;
            this.CreateButton.Location = new System.Drawing.Point(826, 454);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(175, 70);
            this.CreateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CreateButton.TabIndex = 3;
            this.CreateButton.TabStop = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.CreateFile;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1118, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.SearchDirectoryToCreate);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FileDirectory);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormCreateFile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateFile";
            ((System.ComponentModel.ISupportInitialize)(this.SearchDirectoryToCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox FileDirectory;
        private System.Windows.Forms.PictureBox CreateButton;
        private System.Windows.Forms.PictureBox SearchDirectoryToCreate;
    }
}