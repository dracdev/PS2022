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
            DoctorDTO dto = new DoctorDTO();

            dto.Id = entity.Id;
            dto.UserId = entity.UserId;
            dto.Name = entity.Name;
            dto.IsSpecialist = entity.IsSpecialist;
            dto.User = entity.User.ToDTO();
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;

            return dto;
        }


        internal static Doctor ToEntity(this DoctorDTO dto) 
        {
            Doctor entity = new Doctor();

            entity.Id = dto.Id;
            entity.UserId = dto.UserId;
            entity.Name = dto.Name;
            entity.IsSpecialist = dto.IsSpecialist;
            entity.User = dto.User.ToEntity();
            entity.CreatedAt = dto.CreatedAt;
            entity.UpdatedAt = dto.UpdatedAt;

            return entity;
        }

        internal static IEnumerable<DoctorDTO> ToDTOs(this IEnumerable<Doctor> entities) => entities.Select(e => e.ToDTO());
        internal static IEnumerable<Doctor> ToEntities(this IEnumerable<DoctorDTO> dtos) => dtos.Select(e => e.ToEntity());
    }
}
