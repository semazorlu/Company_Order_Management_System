namespace CompanyOrderManagement.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public bool ApprovalStatus { get; set; }
        public TimeSpan OrderStartTime { get; set; }
        public TimeSpan OrderEndTime { get; set; }
    }
}
