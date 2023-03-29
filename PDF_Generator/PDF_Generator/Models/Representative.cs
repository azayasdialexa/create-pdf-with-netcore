namespace PDF_Generator.Models 
{
    public class Representative 
    { 
        public int ListingId { get; set; }
        public string Name { get; set; } 
        public string Title { get; set; }
        public ContactInfo[] Contact { get; set; }
    }
}