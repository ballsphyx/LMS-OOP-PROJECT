namespace ColegioLibrarySystem.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int CatId { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public Category Category { get; set; }
        public List<BookCopy> BookCopies { get; set; }
    }
}
