using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCenterCRM.Api.Dto
{
    public class PaginationDto
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}
