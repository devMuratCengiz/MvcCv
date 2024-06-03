using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Business.Abstract;
using MvcCv.DTO.DTOs.AboutDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.ViewComponents.HomeIndex
{
    public class _HomeAbout(IGenericService<About> _service,IMapper _mapper) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _service.TGetAll();
            var list = _mapper.Map<List<ResultAboutDto>>(values);
            return View(list);
        }
    }
}
