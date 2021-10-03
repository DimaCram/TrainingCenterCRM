using Microsoft.AspNetCore.Identity;

namespace TrainingCenterCRM.Core.Models
{
    public class User : IdentityUser
    {
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public Manager Manager { get; set; }
    }
}
