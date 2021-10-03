using System.Collections.Generic;

namespace TrainingCenterCRM.Core.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }
        public string PathToIcon { get; set; }

        public List<Group> Groups = new List<Group>();

        public User User { get; set; }
        public string UserId { get; set; }
    }
}
