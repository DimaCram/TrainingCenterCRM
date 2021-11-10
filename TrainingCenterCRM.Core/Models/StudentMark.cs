using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterCRM.Core.Models
{
    public class StudentMark
    {
        public int Id { get; set; }
        public byte Mark { get; set; }
        public string Comment { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
