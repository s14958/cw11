using Cwiczenia11.DTOs.Requests;
using Cwiczenia11.Models;
using Cwiczenia11.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Controllers
{
    [ApiController]
    [Route("/api/doctors")]
    public class DoctorsController : Controller
    {
        private IDoctorsDbService _doctorsDbService;

        public DoctorsController(IDoctorsDbService doctorsDbService)
        {
            _doctorsDbService = doctorsDbService;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_doctorsDbService.GetDoctors());
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            return Ok(_doctorsDbService.GetDoctor(id));
        }

        [HttpPost]
        public IActionResult AddDoctor(AddDoctorRequestDto request)
        {
            return Ok(_doctorsDbService.AddDoctor(request));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            return Ok(_doctorsDbService.DeleteDoctor(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(int id, AddDoctorRequestDto request)
        {
            return Ok(_doctorsDbService.UpdateDoctor(id, request));
        }
    }
}
