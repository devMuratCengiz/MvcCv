using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Business.Abstract;
using MvcCv.DTO.DTOs.EducationDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.ViewComponents.HomeIndex
{
    public class _HomeEducation(IGenericService<Education> _service,IMapper _mapper) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _service.TGetAll();
            var list = _mapper.Map<List<ResultEducationDto>>(values);
            return View(list);
        }
    }
}
