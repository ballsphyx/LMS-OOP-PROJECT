using ColegioLibrarySystem.GlobalEnums;

namespace ColegioLibrarySystem.Models
{
    public class BookCopy
    {
        public int CopyId { get; set; }
        public int BookId { get; set; }
        public StatusEnum CopyStatus { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Book book { get; set; }
    }
}
