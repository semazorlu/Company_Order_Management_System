namespace CompanyOrderManagement.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string PersonName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
