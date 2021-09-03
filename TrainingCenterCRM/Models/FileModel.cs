using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] Data { get; set; }
        public DateTime CreateDate { get; set; }

        public List<MaterialModel> Materials { get; set; }
    }
}
