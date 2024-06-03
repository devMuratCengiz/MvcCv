using AutoMapper;
using MvcCv.DTO.DTOs.AboutDtos;
using MvcCv.DTO.DTOs.CertificateDtos;
using MvcCv.DTO.DTOs.EducationDtos;
using MvcCv.DTO.DTOs.ExperienceDtos;
using MvcCv.DTO.DTOs.InterestDtos;
using MvcCv.DTO.DTOs.SkillDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.Mapper
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();

            CreateMap<CreateCertificateDto, Certificate>().ReverseMap();
            CreateMap<UpdateCertificateDto, Certificate>().ReverseMap();
            CreateMap<ResultCertificateDto, Certificate>().ReverseMap();

            CreateMap<CreateEducationDto, Education>().ReverseMap();
            CreateMap<UpdateEducationDto, Education>().ReverseMap();
            CreateMap<ResultEducationDto, Education>().ReverseMap();

            CreateMap<CreateExperienceDto, Experience>().ReverseMap();
            CreateMap<UpdateExperienceDto, Experience>().ReverseMap();
            CreateMap<ResultExperienceDto, Experience>().ReverseMap();

            CreateMap<CreateInterestDto, Interest>().ReverseMap();
            CreateMap<UpdateInterestDto, Interest>().ReverseMap();
            CreateMap<ResultInterestDto, Interest>().ReverseMap();

            CreateMap<CreateSkillDto, Skill>().ReverseMap();
            CreateMap<UpdateSkillDto, Skill>().ReverseMap();
            CreateMap<ResultSkillDto, Skill>().ReverseMap();
        }
    }
}
