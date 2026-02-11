namespace ResumeProject.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public int? CategoryId { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
    }
}
