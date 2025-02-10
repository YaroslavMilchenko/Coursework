using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Menu : Form
    {
        private string filePath;
        private FormMain mainForm;
        string author;
        string title;
        string language;
        string publisher;
        string category;
        string format;
        string description;
        string line;

        public Menu()
        {
            InitializeComponent();
        }

        // Конструктор з параметрами для отримання шляху до файлу і посилання на головну форму
        public Menu(string filePath, FormMain mainForm) : this()
        {
            this.filePath = filePath;
            this.mainForm = mainForm;
        }

        // Метод для збереження даних з InfoTable у файл
        private void SaveBooksToFile()
        {
            SaveBooksToFile(filePath);
        }

        // Метод для збереження у вказаний файл
        private void SaveBooksToFile(string path)
        {
            try
            {
                List<string> lines = new List<string>();

                // Перевірка наявності InfoTable через mainForm
                if (mainForm.InfoTableGrid != null)
                {
                    foreach (DataGridViewRow row in mainForm.InfoTableGrid.Rows)
                    {
                        if (row.IsNewRow) continue;

                        try
                        {
                            // Перевірка типу даних для кожної комірки
                            author = row.Cells["Author"].Value?.ToString() ?? throw new Exception("Автор. Комірка не може бути порожньою.");
                            title = row.Cells["Title"].Value?.ToString() ?? throw new Exception("Назва. Комірка не може бути порожньою.");

                            if (!int.TryParse(row.Cells["Year"].Value?.ToString(), out int year))
                                throw new Exception("Рік. Комірка не може бути порожньою або має бути цілим числом.");

                            language = row.Cells["Language"].Value?.ToString() ?? throw new Exception("Мова. Комірка не може бути порожньою.");
                            publisher = row.Cells["Publisher"].Value?.ToString() ?? throw new Exception("Видавництво. Комірка не може бути порожньою.");

                            if (!decimal.TryParse(row.Cells["Price"].Value?.ToString(), out decimal price))
                                throw new Exception("Ціна. Комірка не може бути порожньою або має бути числом.");

                            category = row.Cells["Category"].Value?.ToString() ?? throw new Exception("Категорія. Комірка не може бути порожньою.");
                            format = row.Cells["Format"].Value?.ToString() ?? throw new Exception("Формат. Комірка не може бути порожньою.");
                            description = row.Cells["Description"].Value?.ToString() ?? "";

                            // Формування рядка для збереження
                            line = $"{author};{title};{year};{language};{publisher};{price};{category};{format};{description}";
                            lines.Add(line);
                        }
                        catch (Exception ex)
                        {
                            // Викидання винятку, якщо типи даних не відповідають вимогам
                            MessageBox.Show("Помилка в рядку: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    File.WriteAllLines(path, lines);
                    MessageBox.Show("Зміни збережено!", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Таблиця InfoTable не знайдена.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні файлу: " + ex.Message);
            }
        }


        private void Exit_Click(object sender, EventArgs e) // Функія для виходу з застосунку
        {
            Application.Exit();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                SaveBooksToFile();
            }
            else
            {
                SaveAs_Click(sender, e); // Якщо файл не заданий, викликаєм "Зберегти як"
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
                saveFileDialog.Title = "Зберегти файл як";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "books.txt"; // Ім'я файлу за замовчуванням

                // Відкриття діалогового вікна для вибору шляху
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName; // Новий шлях для збереження
                    SaveBooksToFile(filePath); // Зберігаємо дані у вибраний файл
                }
            }
        }
    }
}
