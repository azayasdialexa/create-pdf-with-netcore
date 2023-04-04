namespace PDF_Generator.Models 
{
    public class Agent 
    { 
        public int ListingId { get; set; }
        public int AgentId { get; set; }
        public string Name { get; set; } 
        public string Title { get; set; }
        public string Avatar { get; set; }
        public ContactInfo[] Contact { get; set; }
    }
}