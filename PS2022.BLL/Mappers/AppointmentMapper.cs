using PS2022.BLL.Dto;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS2022.BLL.Mappers
{
    internal static class AppointmentMapper
    {
        internal static AppointmentDTO ToDTO(this Appointment entity) 
        {
            AppointmentDTO dto = new AppointmentDTO
            {
                Id = entity.Id,
                PatientId = entity.PatientId,
                DoctorId = entity.DoctorId,
                Doctor = entity.Doctor.ToDTO(),
                Patient = entity.Patient.ToDTO(),
                StartTime = entity.StartTime,
                DurationMin = entity.DurationMin,
                UpdatedAt = entity.UpdatedAt,
                CreatedAt = entity.CreatedAt
            };

            return dto;
        }
        internal static Appointment ToEntity(this AppointmentDTO dto) 
        {
            Appointment entity = new Appointment
            {
                Id = dto.Id,
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                Doctor = dto.Doctor.ToEntity(),
                Patient = dto.Patient.ToEntity(),
                StartTime = dto.StartTime,
                DurationMin = dto.DurationMin,
                UpdatedAt = dto.UpdatedAt,
                CreatedAt = dto.CreatedAt
            };

            return entity;
        }

        internal static IEnumerable<AppointmentDTO> ToDTOs(this IEnumerable<Appointment> entities) => entities.Select(e => e.ToDTO());
        internal static IEnumerable<Appointment> ToEntities(this IEnumerable<AppointmentDTO> dtos) => dtos.Select(e => e.ToEntity());

    }
}
