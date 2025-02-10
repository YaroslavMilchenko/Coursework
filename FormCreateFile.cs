using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FormCreateFile : Form
    {
        string fileName;
        string directory;
        string fullPath;
        public FormCreateFile()
        {
            InitializeComponent();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            fileName = FileName.Text;
            directory = FileDirectory.Text;

            // Перевіряємо, чи заповнені всі текстбокси
            if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(directory))
            {
                try
                {
                    // Створюємо змінну, в якій будемо зберігати шлях до нашого файлу
                    fullPath = Path.Combine(directory, fileName + ".txt");

                    // Перевірка на існування файлу з такою назвою
                    if (!File.Exists(fullPath))
                    {
                        File.Create(fullPath);

                        // Сповіщення про поточний стан
                        MessageBox.Show("Файл успішно створений", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Закриваємо це вікно
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Файл з таким ім'ям вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Обробка виняткових ситуацій
                    MessageBox.Show($"Виникла помилка при створенні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Якщо поля пусті, сповіщюємо про це користувача
                MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Створення кнопки для допомоги користувачу у пошуку директорії
        private void SearchDirectoryToCreate_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    FileDirectory.Text = folderBrowser.SelectedPath;
                }
            }
        }

    }
}
