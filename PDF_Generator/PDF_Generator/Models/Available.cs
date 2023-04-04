namespace PDF_Generator.Models 
{
    public class Available 
    {
        public int ListingId { get; set; }
        public int MarketId { get; set; }
        public string Name { get; set; }
        public string FullAddress { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string State { get; set; } 
        public string TotalSF { get; set; }
        public string AvailableDate { get; set; }
        public string ListingRep { get; set; }
        public string HeroImage { get; set; }
    }
}