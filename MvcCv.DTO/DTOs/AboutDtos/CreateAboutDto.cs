﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCv.DTO.DTOs.AboutDtos
{
    public class CreateAboutDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string LinkedInUrl { get; set; }
        public string GithubUrl { get; set; }
    }
}
