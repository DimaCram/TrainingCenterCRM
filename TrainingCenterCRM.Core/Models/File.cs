using System;

namespace TrainingCenterCRM.Core.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] Data { get; set; }
        public DateTime CreateDate { get; set; }

        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
