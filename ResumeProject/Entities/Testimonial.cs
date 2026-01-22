using Microsoft.AspNetCore.Components.Web;

namespace ResumeProject.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Fullname { get; set; }
        public string TitleAndCompany { get; set; }
        public string CommentDetail { get; set; }
        public string ImageURL { get; set; }
        public bool IsConfirm { get; set; }
    }
}
