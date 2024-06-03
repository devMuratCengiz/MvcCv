using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Business.Abstract;
using MvcCv.DTO.DTOs.SkillDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Route("[area]/[controller]/[action]/{id?}")]

    [Authorize(Roles = "Admin")]
    public class SkillController(IGenericService<Skill> _service, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _service.TGetAll();
            var list = _mapper.Map<List<ResultSkillDto>>(values);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateSkillDto createSkillDto)
        {
            var value = _mapper.Map<Skill>(createSkillDto);
            _service.TCreate(value);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var value = _service.TGetById(id);
            var updateValue = _mapper.Map<UpdateSkillDto>(value);
            return View(updateValue);
        }
        [HttpPost]
        public IActionResult Update(UpdateSkillDto updateSkillDto)
        {
            var value = _mapper.Map<Skill>(updateSkillDto);
            _service.TUpdate(value);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _service.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
