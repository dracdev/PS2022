using PS2022.BLL.Dto;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Mappers
{
    internal static class AppointmentMapper
    {
        internal static AppointmentDTO ToDTO(this Appointment entity) 
        {
            AppointmentDTO dto = new AppointmentDTO();

            dto.Id = entity.Id;
            dto.PatientId = entity.PatientId;
            dto.DoctorId = entity.DoctorId;
            dto.Doctor = entity.Doctor.ToDTO();
            dto.Patient = entity.Patient.ToDTO();
            dto.StartTime = entity.StartTime;
            dto.DurationMin = entity.DurationMin;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.CreatedAt = entity.CreatedAt;

            return dto;
        }
        internal static Appointment ToEntity(this AppointmentDTO dto) 
        {
            Appointment entity = new Appointment();

            entity.Id = dto.Id;
            entity.PatientId = dto.PatientId;
            entity.DoctorId = dto.DoctorId;
            entity.Doctor = dto.Doctor.ToEntity();
            entity.Patient = dto.Patient.ToEntity();
            entity.StartTime = dto.StartTime;
            entity.DurationMin = dto.DurationMin;
            entity.UpdatedAt = dto.UpdatedAt;
            entity.CreatedAt = dto.CreatedAt;

            return entity;

        }
    }
}
