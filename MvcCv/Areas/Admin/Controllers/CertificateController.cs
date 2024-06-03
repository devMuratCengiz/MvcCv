using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Business.Abstract;
using MvcCv.DTO.DTOs.CertificateDtos;
using MvcCv.Entity.Entities;

namespace MvcCv.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Route("[area]/[controller]/[action]/{id?}")]

    [Authorize(Roles = "Admin")]
    public class CertificateController(IGenericService<Certificate> _service,IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _service.TGetAll();
            var list = _mapper.Map<List<ResultCertificateDto>>(values);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCertificateDto createCertificateDto)
        {
            var value = _mapper.Map<Certificate>(createCertificateDto);
            _service.TCreate(value);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var value = _service.TGetById(id);
            var updateValue = _mapper.Map<UpdateCertificateDto>(value);
            return View(updateValue);
        }
        [HttpPost]
        public IActionResult Update(UpdateCertificateDto updateCertificateDto)
        {
            var value = _mapper.Map<Certificate>(updateCertificateDto);
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
