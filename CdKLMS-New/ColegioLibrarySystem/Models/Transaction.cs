namespace ColegioLibrarySystem.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int CopyID { get; set; }
        public int UserID { get; set; }
        public int Quantity { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DateReturned { get; set; }
        public User User { get; set; }
        public BookCopy BookCopy { get; set; }
    }
}
