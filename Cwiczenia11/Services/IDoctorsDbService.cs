using Cwiczenia11.DTOs.Requests;
using Cwiczenia11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Services
{
    public interface IDoctorsDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public Doctor GetDoctor(int id);
        public Doctor AddDoctor(AddDoctorRequestDto request);
        public Doctor DeleteDoctor(int id);
        public Doctor UpdateDoctor(int id, AddDoctorRequestDto request);
    }
}
