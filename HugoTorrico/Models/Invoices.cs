namespace HugoTorrico.Models
{
    public class Invoices
    {
        public int InvoicesId { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Total { get; set; }
    }
}