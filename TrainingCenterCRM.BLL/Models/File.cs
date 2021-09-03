using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.BLL.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] Data { get; set; }
        public DateTime CreateDate { get; set; }

        public List<Material> Materials { get; set; }
    }
}
