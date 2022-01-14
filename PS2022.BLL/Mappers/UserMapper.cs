using PS2022.BLL.Dto;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS2022.BLL.Mappers
{
    internal static class UserMapper
    {
        //TODO: Conversion of enum role

        internal static UserDTO ToDTO(this User entity) 
        {
            UserDTO dto = new UserDTO();

            dto.Id = entity.Id;
            dto.Username = entity.Username;
            dto.Password = entity.Password;
            dto.Role = entity.Role; //ENUM CONVERSION

            //   dto.patients = entity.patients.todto.tolist
            dto.Doctors = (List<DoctorDTO>)entity.Doctors;
            dto.Doctors = (List<DoctorDTO>)entity.Doctors.ToDTOs();
            dto.Patients = (List<PatientDTO>)entity.Patients.ToDTOs();
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;

            return dto;
        }


        internal static User ToEntity(this UserDTO dto) 
        {
            User entity = new User();

            entity.Id = dto.Id;
            entity.Username = dto.Username;
            entity.Password = dto.Password;
            entity.Role = dto.Role;
            entity.Doctors = (ICollection<Doctor>)dto.Doctors.ToEntities();
            entity.Patients = (ICollection<Patient>)dto.Patients.ToEntities();
            entity.CreatedAt = dto.CreatedAt;
            entity.UpdatedAt = dto.UpdatedAt;

            return entity;
        }

        internal static IEnumerable<UserDTO> ToDTOs(this IEnumerable<User> entities) => entities.Select(e => e.ToDTO());
        internal static IEnumerable<User> ToEntities(this IEnumerable<UserDTO> dtos) => dtos.Select(e => e.ToEntity());
    }
}
