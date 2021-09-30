using System.Collections.Generic;

namespace TrainingCenterCRM.BLL.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WorkingType MaterialType { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }

    public enum WorkingType
    {
        HomeWork,
        LessonWork
    }
}