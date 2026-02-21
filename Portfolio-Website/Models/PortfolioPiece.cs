namespace Portfolio_Website.Models
{
    public class PortfolioPiece
    {
        public required string ID { get; set; }
        public required string Title { get; set; }
        public required string Category { get; set; }
        public required string Description { get; set; }
        public string Image { get; set; } = "";
        public List<string> Images { get; set; } = new();
    }
}