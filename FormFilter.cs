using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Coursework.FormMain;

namespace Coursework
{
    public partial class FormFilter : Form
    {
        private FormMain mainForm;
        string selectedCategory;
        string sortMethod;
        string sortingFormat;
        string sortBy;

        public FormFilter()
        {
            InitializeComponent();
            InitializeFilterOptions();
        }

        public FormFilter(FormMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            InitializeFilterOptions();
        }

        private void InitializeFilterOptions()
        {
            if (CategoryChoice != null)
            {
                CategoryChoice.Items.AddRange(new string[] { "Художня", "Комп'ютерна" });
            }
            if (SortFormat != null)
            {
                SortFormat.Items.AddRange(new string[] { "Паперова", "Електронна", "Аудіо" });
            }
            if (SortingMethod != null)
            {
                SortingMethod.Items.AddRange(new string[] { "За зростанням", "За спаданням" });
            }
            if (SortBy != null)
            {
                SortBy.Items.AddRange(new string[] { "Найдоржчі", "Найдешевші" });
            }
        }

        private void CancelAllFilters_Click(object sender, EventArgs e)
        {
            mainForm.LoadBooksToGrid(mainForm.GetAllBooks());
            MessageBox.Show("Всі фільтри скасовано. Показано оригінальний список.");
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (CategoryChoice.SelectedItem != null)
            {
                selectedCategory = CategoryChoice.SelectedItem.ToString();
                var filteredBooks = mainForm.GetAllBooks().Where(book =>
                    string.IsNullOrEmpty(selectedCategory) || book.Category == selectedCategory
                ).ToList();

                mainForm.LoadBooksToGrid(filteredBooks);
                MessageBox.Show($"Фільтрація за категорією: {selectedCategory}. Показано {filteredBooks.Count} книг.");
            }
            else
            {
                MessageBox.Show("Оберіть категорію для фільтрації.");
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            sortMethod = SortFormat.SelectedItem?.ToString();
            sortingFormat = SortingMethod.SelectedItem?.ToString();

            if (sortMethod == null || sortingFormat == null)
            {
                MessageBox.Show("Оберіть метод і формат сортування.");
                return;
            }

            // Фільтруємо книги за форматом
            List<Book> filteredBooks = mainForm.GetAllBooks().Where(b => b.Format == sortMethod).ToList();

            // Сортуємо за алгоритмом Шелла
            List<Book> sortedBooks = ShellSort(filteredBooks, sortingFormat == "За зростанням");

            mainForm.LoadBooksToGrid(sortedBooks);
            this.Close();
            MessageBox.Show($"Сортування за {sortMethod} ({sortingFormat}). Показано {sortedBooks.Count} книг.");
        }

        private List<Book> ShellSort(List<Book> books, bool ascending)
        {
            int n = books.Count;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    Book temp = books[i];
                    int j;

                    for (j = i; j >= gap &&
                        (ascending ? temp.Price < books[j - gap].Price : temp.Price > books[j - gap].Price);
                        j -= gap)
                    {
                        books[j] = books[j - gap]; 
                    }
                    books[j] = temp; 
                }
            }
            return books;
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            // Перевірка на вибір варіанту сортування і кількості книжок
            if (SortBy.SelectedItem == null)
            {
                MessageBox.Show("Оберіть варіант сортування: Найдоржчі або Найдешевші.");
                return;
            }

            if (!int.TryParse(CountTextBox.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Введіть коректну кількість книжок.");
                return;
            }

            sortBy = SortBy.SelectedItem.ToString();
            List<Book> books = mainForm.GetAllBooks(); // Створення нового списку для опрацювання фільрації і дотримані принципів інкапсуляції

            // Сортування
            if (sortBy == "Найдоржчі")
            {
                books = books.OrderByDescending(b => b.Price).Take(count).ToList();
            }
            else if (sortBy == "Найдешевші")
            {
                books = books.OrderBy(b => b.Price).Take(count).ToList();
            }

            // Завантаження книжок у таблицю
            mainForm.LoadBooksToGrid(books);
            MessageBox.Show($"Показано {books.Count} книг за критерієм '{sortBy}'.");
        }

    }
}
