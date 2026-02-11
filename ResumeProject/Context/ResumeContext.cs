using Microsoft.EntityFrameworkCore;
using ResumeProject.Entities;

namespace ResumeProject.Context
{
    public class ResumeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;initial catalog=ResumeDB;integrated security=true; trust server certificate=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceDescription> ServiceDescription { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Highlight> Highlights { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillDescription> SkillDescription { get; set; }
    }
}
