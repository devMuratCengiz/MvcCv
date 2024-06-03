using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Business.Abstract;
using MvcCv.DTO.DTOs.AboutDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Route("[area]/[controller]/[action]/{id?}")]

    [Authorize(Roles ="Admin")]
    public class AboutController(IGenericService<About> _service, IMapper _mapper) : Controller
    {
        
        public IActionResult Index()
        {
            var values = _service.TGetAll();
            var list = _mapper.Map<List<ResultAboutDto>>(values);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var value = _mapper.Map<About>(createAboutDto);
            _service.TCreate(value);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var value = _service.TGetById(id);
            var updateValue = _mapper.Map<UpdateAboutDto>(value);
            return View(updateValue);
        }
        [HttpPost]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var values = _mapper.Map<About>(updateAboutDto);
            _service.TUpdate(values);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _service.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
