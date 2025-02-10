namespace Coursework
{
    partial class FormFilter
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryChoice = new System.Windows.Forms.ListBox();
            this.SortFormat = new System.Windows.Forms.ListBox();
            this.SortingMethod = new System.Windows.Forms.ListBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.OutputButton = new System.Windows.Forms.PictureBox();
            this.FilterButton = new System.Windows.Forms.PictureBox();
            this.SortButton = new System.Windows.Forms.PictureBox();
            this.CancelAllFilters = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SortBy = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelAllFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // CategoryChoice
            // 
            this.CategoryChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.CategoryChoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryChoice.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryChoice.FormattingEnabled = true;
            this.CategoryChoice.ItemHeight = 42;
            this.CategoryChoice.Location = new System.Drawing.Point(40, 109);
            this.CategoryChoice.Name = "CategoryChoice";
            this.CategoryChoice.Size = new System.Drawing.Size(240, 84);
            this.CategoryChoice.TabIndex = 3;
            // 
            // SortFormat
            // 
            this.SortFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SortFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SortFormat.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortFormat.FormattingEnabled = true;
            this.SortFormat.ItemHeight = 42;
            this.SortFormat.Location = new System.Drawing.Point(40, 302);
            this.SortFormat.Name = "SortFormat";
            this.SortFormat.Size = new System.Drawing.Size(247, 84);
            this.SortFormat.TabIndex = 4;
            // 
            // SortingMethod
            // 
            this.SortingMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SortingMethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SortingMethod.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingMethod.FormattingEnabled = true;
            this.SortingMethod.ItemHeight = 34;
            this.SortingMethod.Location = new System.Drawing.Point(310, 293);
            this.SortingMethod.Name = "SortingMethod";
            this.SortingMethod.Size = new System.Drawing.Size(210, 102);
            this.SortingMethod.TabIndex = 5;
            // 
            // CountTextBox
            // 
            this.CountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.CountTextBox.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTextBox.Location = new System.Drawing.Point(40, 488);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(439, 62);
            this.CountTextBox.TabIndex = 6;
            // 
            // OutputButton
            // 
            this.OutputButton.Image = global::Coursework.Properties.Resources.Вивести;
            this.OutputButton.Location = new System.Drawing.Point(657, 557);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(250, 125);
            this.OutputButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OutputButton.TabIndex = 8;
            this.OutputButton.TabStop = false;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Image = global::Coursework.Properties.Resources.Фільтрувати2_0;
            this.FilterButton.Location = new System.Drawing.Point(657, 184);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(250, 125);
            this.FilterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FilterButton.TabIndex = 7;
            this.FilterButton.TabStop = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Image = global::Coursework.Properties.Resources.Сортувати2_0;
            this.SortButton.Location = new System.Drawing.Point(657, 377);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(250, 125);
            this.SortButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SortButton.TabIndex = 2;
            this.SortButton.TabStop = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // CancelAllFilters
            // 
            this.CancelAllFilters.Image = global::Coursework.Properties.Resources.Скинути_всі_фільтри;
            this.CancelAllFilters.Location = new System.Drawing.Point(657, 2);
            this.CancelAllFilters.Name = "CancelAllFilters";
            this.CancelAllFilters.Size = new System.Drawing.Size(250, 125);
            this.CancelAllFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CancelAllFilters.TabIndex = 1;
            this.CancelAllFilters.TabStop = false;
            this.CancelAllFilters.Click += new System.EventHandler(this.CancelAllFilters_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.Вікно_сортування2_0;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SortBy
            // 
            this.SortBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SortBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SortBy.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortBy.FormattingEnabled = true;
            this.SortBy.ItemHeight = 42;
            this.SortBy.Location = new System.Drawing.Point(40, 581);
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(439, 126);
            this.SortBy.TabIndex = 9;
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 723);
            this.Controls.Add(this.SortBy);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.SortingMethod);
            this.Controls.Add(this.SortFormat);
            this.Controls.Add(this.CategoryChoice);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.CancelAllFilters);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormFilter";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelAllFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CancelAllFilters;
        private System.Windows.Forms.PictureBox SortButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ListBox CategoryChoice;
        private System.Windows.Forms.ListBox SortFormat;
        private System.Windows.Forms.ListBox SortingMethod;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.PictureBox FilterButton;
        private System.Windows.Forms.PictureBox OutputButton;
        private System.Windows.Forms.ListBox SortBy;
    }
}