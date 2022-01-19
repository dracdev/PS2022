using PS2022.BLL.Dto;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS2022.BLL.Mappers
{
    internal static class DoctorMapper
    {

        internal static DoctorDTO ToDTO(this Doctor entity) 
        {
            DoctorDTO dto = new DoctorDTO
            {
                Id = entity.Id,
                UserId = entity.UserId,
                Name = entity.Name,
                IsSpecialist = entity.IsSpecialist,
                User = entity.User.ToDTO(),
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };

            return dto;
        }


        internal static Doctor ToEntity(this DoctorDTO dto) 
        {
            Doctor entity = new Doctor
            {
                Id = dto.Id,
                UserId = dto.UserId,
                Name = dto.Name,
                IsSpecialist = dto.IsSpecialist,
                User = dto.User.ToEntity(),
                CreatedAt = dto.CreatedAt,
                UpdatedAt = dto.UpdatedAt
            };

            return entity;
        }

        internal static IEnumerable<DoctorDTO> ToDTOs(this IEnumerable<Doctor> entities) => entities.Select(e => e.ToDTO());
        internal static IEnumerable<Doctor> ToEntities(this IEnumerable<DoctorDTO> dtos) => dtos.Select(e => e.ToEntity());
    }
}
