using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class StartWindow : Form
    {
        string filePath;
        public StartWindow()
        {
            InitializeComponent();
        }

        private void OpenFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                this.Hide(); // Закриваємо це вікно
                FormMain formMain = new FormMain(filePath); // Передача шляху відкриття файлу в конструктор основного вікна
                formMain.Show();

            }

        }


        private void CreateNewFile_Click(object sender, EventArgs e)
        {
            FormCreateFile createFileForm = new FormCreateFile();
            if (createFileForm.ShowDialog() == DialogResult.OK)
            {
                this.Hide(); // Закриваємо це вікно
                FormMain mainForm = new FormMain();
                mainForm.Show(); // Відкриваємо основне вікно
            }
        }
    }
}
