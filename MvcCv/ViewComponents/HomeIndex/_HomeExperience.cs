using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Business.Abstract;
using MvcCv.DTO.DTOs.ExperienceDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.ViewComponents.HomeIndex
{
    public class _HomeExperience(IGenericService<Experience> _service, IMapper _mapper) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = _service.TGetAll();
            var list = _mapper.Map<List<ResultExperienceDto>>(value);
            return View(list);
        }
    }
}
