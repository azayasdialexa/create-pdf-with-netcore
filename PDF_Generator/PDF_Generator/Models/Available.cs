namespace PDF_Generator.Models 
{
    public class Available 
    { 
        public int MarketId { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string State { get; set; } 
        public int TotalSF { get; set; }
        public int ClearHt { get; set; }
        public int Doors { get; set; }
        public string AvailableDate { get; set; }
        public string ListingRep { get; set; }
    }
}