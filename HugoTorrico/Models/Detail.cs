namespace HugoTorrico.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
    }
}