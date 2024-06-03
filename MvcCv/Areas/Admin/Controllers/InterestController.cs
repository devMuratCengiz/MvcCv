using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Business.Abstract;
using MvcCv.DTO.DTOs.InterestDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Route("[area]/[controller]/[action]/{id?}")]

    [Authorize(Roles = "Admin")]
    public class InterestController(IGenericService<Interest> _service, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _service.TGetAll();
            var list = _mapper.Map<List<ResultInterestDto>>(values);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateInterestDto createInterestDto)
        {
            var value = _mapper.Map<Interest>(createInterestDto);
            _service.TCreate(value);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var value = _service.TGetById(id);
            var updateValue = _mapper.Map<UpdateInterestDto>(value);
            return View(updateValue);
        }
        [HttpPost]
        public IActionResult Update(UpdateInterestDto updateInterestDto)
        {
            var value = _mapper.Map<Interest>(updateInterestDto);
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
