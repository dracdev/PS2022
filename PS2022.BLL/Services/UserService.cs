using PS2022.BLL.Dto;
using PS2022.BLL.Interfaces.Services;
using PS2022.BLL.Mappers;
using PS2022.DAL.Interfaces.Repository;
using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS2022.BLL.Services
{
    public class  UserService : IUserService
    {
        private IGenericRepository<User> _repository;

        public UserService(IGenericRepository<User> repository) 
        {
            _repository = repository;
        }

        public UserDTO Create(UserDTO dto)
        {
            dto.ValidateForCreation();

            dto.CreatedAt = DateTime.UtcNow;
            dto.UpdatedAt = DateTime.UtcNow;

            var entity = _repository.Create(dto.ToEntity());

            var result = entity.ToDTO();

            return result;
        }

        public List<UserDTO> GetAll()
        {
            return _repository.GetAll().ToDTOs().ToList();
        }

        public UserDTO GetById(int id)
        {
            return _repository.GetById(id).ToDTO();
        }

        public UserDTO Update(UserDTO dto)
        {
            dto.ValidateForUpdate();
            dto.UpdatedAt = DateTime.UtcNow;

            var result = _repository.Update(dto.ToEntity()).ToDTO();

            return result;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
