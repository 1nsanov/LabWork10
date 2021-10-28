namespace Task1
{
    public class Book
    {
        public string Author { get; set; }
        private string NameBook { get; set; }
        private int Year { get; set; }
        private string Publisher { get; set; }
        private int CountPage { get; set; }

        public Book(string author, string nameBook, int year, string publisher, int countPage)
        {
            Author = author;
            NameBook = nameBook;
            Year = year;
            Publisher = publisher;
            CountPage = countPage;
        }

        public override string ToString()
        {
            return $"{Author}: {NameBook} | {Year} год. | Издательство: {Publisher} | Объем: {CountPage} стр.";
        }
    }
}
