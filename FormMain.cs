using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FormMain : Form
    {
        private string filePath; // Шлях до файлу
        private List<Book> allBooks = new List<Book>(); // Список всіх книг
        string searchText;

        // Властивість доступу до таблиці з інших вікон
        public DataGridView InfoTableGrid => InfoTable;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string filePath) : this()
        {
            this.filePath = filePath;
            InitializeDataGridView();

            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                LoadBooksFromFile(filePath);
            }
        }


        //Ініціалізація колонок в таблиці
        private void InitializeDataGridView()
        {
            InfoTable.Columns.Add("Author", "Автор");
            InfoTable.Columns.Add("Title", "Назва");
            InfoTable.Columns.Add("Year", "Рік");
            InfoTable.Columns.Add("Language", "Мова");
            InfoTable.Columns.Add("Publisher", "Видавництво");
            InfoTable.Columns.Add("Price", "Ціна");
            InfoTable.Columns.Add("Category", "Категорія");
            InfoTable.Columns.Add("Format", "Формат");
            InfoTable.Columns.Add("Description", "Опис");

            InfoTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Зчитування книжок з файлу, шлях якого передали в параметр
        private void LoadBooksFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    if (parts.Length == 9)
                    {
                        Book book = new Book
                        {
                            Author = parts[0].Trim(),
                            Title = parts[1].Trim(),
                            Year = int.Parse(parts[2].Trim()),
                            Language = parts[3].Trim(),
                            Publisher = parts[4].Trim(),
                            Price = decimal.Parse(parts[5].Trim()),
                            Category = parts[6].Trim(),
                            Format = parts[7].Trim(),
                            Description = parts[8].Trim()
                        };

                        allBooks.Add(book);
                    }
                }

                LoadBooksToGrid(allBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при зчитуванні файлу: " + "Файл не відповідає вимогам");
            }
        }

        // Завантаження книг в таблицю
        public void LoadBooksToGrid(List<Book> books)
        {
            InfoTable.Rows.Clear();

            foreach (Book book in books)
            {
                InfoTable.Rows.Add(book.Author, book.Title, book.Year, book.Language,
                                   book.Publisher, book.Price, book.Category, book.Format, book.Description);
            }
        }

        public List<Book> GetAllBooks()
        {
            return allBooks;
        }
        // Клас книга, який є основним в нашим програмі 
        public class Book
        {
            public string Author { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public string Language { get; set; }
            public string Publisher { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
            public string Format { get; set; }
            public string Description { get; set; }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu(filePath, this);
            menuForm.Show();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            searchText = SearchBox.Text.ToLower();
            var filteredBooks = allBooks.Where(book =>
                book.Author.ToLower().Contains(searchText) ||
                book.Title.ToLower().Contains(searchText) ||
                book.Description.ToLower().Contains(searchText)
            ).ToList();

            LoadBooksToGrid(filteredBooks);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FormFilter form = new FormFilter(this);
            form.Show();
        }

    }
}
