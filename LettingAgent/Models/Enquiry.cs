using Microsoft.AspNetCore.Identity;

namespace LettingAgent.Models
{
    public class Enquiry
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        public string EnquiryText { get; set; }
    }
}
