namespace TestV1.VM
{
    public class VmSale
    {
        public int SID { get; set; }
        public string? SName { get; set; }
        public int? SAge { get; set; }
        public DateTime? SDate { get; set; }
        public string? SPhoto { get; set; }
        public string[]? Title { get; set; }
        public decimal[]? Price { get; set; }
        public List<VmDetail> Details { get; set; } = new List<VmDetail>();
        public class VmDetail
        {
            public int BID { get; set; }
            public int? SID { get; set; }
            public string? Title { get; set; }
            public decimal? Price { get; set; }
        }
    }
}
