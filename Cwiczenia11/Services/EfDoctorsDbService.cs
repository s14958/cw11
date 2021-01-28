using Cwiczenia11.DTOs.Requests;
using Cwiczenia11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Services
{
    public class EfDoctorsDbService : IDoctorsDbService
    {
        private DoctorsDbContext _context;

        public EfDoctorsDbService(DoctorsDbContext context) {
            _context = context;
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public Doctor GetDoctor(int id)
        {
            return _context.Doctors.Find(id);
        }

        public Doctor AddDoctor(AddDoctorRequestDto request)
        {
            var doctor = new Doctor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };

            _context.Add(doctor);
            _context.SaveChanges();

            return doctor;
        }

        public Doctor DeleteDoctor(int id)
        {
            var doctor = new Doctor()
            {
                IdDoctor = id
            };

            _context.Doctors.Attach(doctor);
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();

            return doctor;
        }

        public Doctor UpdateDoctor(int id, AddDoctorRequestDto request)
        {
            var updatedDoctor = new Doctor()
            {
                IdDoctor = id
            };

            _context.Doctors.Attach(updatedDoctor);

            if (request.FirstName != null)
            {
                updatedDoctor.FirstName = request.FirstName;
                _context.Entry(updatedDoctor).Property("FirstName").IsModified = true;
            }

            if (request.LastName != null)
            {
                updatedDoctor.LastName = request.LastName;
                _context.Entry(updatedDoctor).Property("LastName").IsModified = true;
            }

            if (request.Email != null)
            {
                updatedDoctor.Email = request.Email;
                _context.Entry(updatedDoctor).Property("Email").IsModified = true;
            }

            _context.SaveChanges();

            return updatedDoctor;
        }
    }
}
