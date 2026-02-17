namespace ResumeProject.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
