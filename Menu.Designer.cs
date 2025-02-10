namespace Coursework
{
    partial class Menu
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
            this.SaveAs = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.SaveFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SaveAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveFile)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveAs
            // 
            this.SaveAs.Image = global::Coursework.Properties.Resources.Зберегти_як;
            this.SaveAs.Location = new System.Drawing.Point(-3, 215);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(500, 175);
            this.SaveAs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SaveAs.TabIndex = 2;
            this.SaveAs.TabStop = false;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::Coursework.Properties.Resources.Вийти;
            this.Exit.Location = new System.Drawing.Point(-3, 430);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(500, 175);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Exit.TabIndex = 1;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Image = global::Coursework.Properties.Resources.Зберегти_файл;
            this.SaveFile.Location = new System.Drawing.Point(-3, 0);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(500, 175);
            this.SaveFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SaveFile.TabIndex = 0;
            this.SaveFile.TabStop = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 638);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SaveFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.SaveAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SaveFile;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox SaveAs;
    }
}