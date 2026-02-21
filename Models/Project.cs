namespace MonPorfolio.Models
{
    public class Project
    {
        public required string Title { get; set; }
        public required string ShortDescription { get; set; }
        public required string Description { get; set; }
        public required string TechStack { get; set; }
        public required string Color { get; set; }
        public string? ImageUrl { get; set; }

        public string? demo { get; set; }
    }
}
