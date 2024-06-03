using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCv.DTO.DTOs.EducationDtos
{
    public class CreateEducationDto
    {
        public string SchoolName { get; set; }
        public string Department { get; set; }
        public string GPA { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
