using PS2022.BLL.Dto;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS2022.BLL.Mappers
{
    internal static class PatientMapper
    {
        internal static PatientDTO ToDTO(this Patient entity) 
        {
            PatientDTO dto = new PatientDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                DateOfBirth = entity.DateOfBirth,
                UserId = entity.UserId,
                User = entity.User.ToDTO(),
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };

            return dto;
        }

        internal static Patient ToEntity(this PatientDTO dto)
        {
            Patient entity = new Patient
            {
                Id = dto.Id,
                Name = dto.Name,
                DateOfBirth = dto.DateOfBirth,
                UserId = dto.UserId,
                User = dto.User.ToEntity(),
                CreatedAt = dto.CreatedAt,
                UpdatedAt = dto.UpdatedAt
            };

            return entity;
        }

        internal static IEnumerable<PatientDTO> ToDTOs(this IEnumerable<Patient> entities) => entities.Select(e => e.ToDTO());
        internal static IEnumerable<Patient> ToEntities(this IEnumerable<PatientDTO> dtos) => dtos.Select(e => e.ToEntity());
    }
}
