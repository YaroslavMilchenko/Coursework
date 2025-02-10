namespace Coursework
{
    partial class StartWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateNewFile = new System.Windows.Forms.PictureBox();
            this.OpenFromFile = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CreateNewFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateNewFile
            // 
            this.CreateNewFile.Image = global::Coursework.Properties.Resources.Створити_новий_файл;
            this.CreateNewFile.Location = new System.Drawing.Point(910, 450);
            this.CreateNewFile.Name = "CreateNewFile";
            this.CreateNewFile.Size = new System.Drawing.Size(250, 125);
            this.CreateNewFile.TabIndex = 3;
            this.CreateNewFile.TabStop = false;
            this.CreateNewFile.Click += new System.EventHandler(this.CreateNewFile_Click);
            // 
            // OpenFromFile
            // 
            this.OpenFromFile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.OpenFromFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenFromFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenFromFile.Image = global::Coursework.Properties.Resources.Відкрити_з_файлу_з_тінню;
            this.OpenFromFile.Location = new System.Drawing.Point(370, 450);
            this.OpenFromFile.Name = "OpenFromFile";
            this.OpenFromFile.Size = new System.Drawing.Size(250, 125);
            this.OpenFromFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OpenFromFile.TabIndex = 2;
            this.OpenFromFile.TabStop = false;
            this.OpenFromFile.Click += new System.EventHandler(this.OpenFromFile_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Coursework.Properties.Resources.Вітальне_вікно;
            this.pictureBox4.Location = new System.Drawing.Point(-190, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1900, 1040);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // startWindow
            // 
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.CreateNewFile);
            this.Controls.Add(this.OpenFromFile);
            this.Controls.Add(this.pictureBox4);
            this.Name = "startWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CreateNewFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox OpenFromFile;
        private System.Windows.Forms.PictureBox CreateNewFile;
    }
}

