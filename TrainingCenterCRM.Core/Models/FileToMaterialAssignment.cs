namespace TrainingCenterCRM.Core.Models
{
    public class FileToMaterialAssignment
    {
        public int Id { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int FileId { get; set; }
        public File File { get; set; }
    }
}
