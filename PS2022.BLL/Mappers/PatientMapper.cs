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
            PatientDTO dto = new PatientDTO();

            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.DateOfBirth = entity.DateOfBirth;
            dto.UserId = entity.UserId;
            dto.User = entity.User;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;

            return dto;
        }

        internal static Patient ToEntity(this PatientDTO dto)
        {
            Patient entity = new Patient();

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.DateOfBirth = dto.DateOfBirth;
            entity.UserId = dto.UserId;
            entity.User = dto.User;
            entity.CreatedAt = dto.CreatedAt;
            entity.UpdatedAt = dto.UpdatedAt;

            return entity;
        }

        internal static IEnumerable<PatientDTO> ToDTOs(this IEnumerable<Patient> entities) => entities.Select(e => e.ToDTO());

        internal static IEnumerable<Patient> ToEntities(this IEnumerable<PatientDTO> dtos) => dtos.Select(e => e.ToEntity());
    }
}
