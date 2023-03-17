namespace Practice.BookStore.Data
{
    public class Books
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }
    }
}
