using PS2022.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Interfaces.Services
{
    public interface IUserService
    {
        public UserDTO Create(UserDTO dto);
        public UserDTO GetById(int id);
        public List<UserDTO> GetAll();
        public UserDTO Update(UserDTO dto);
        public void Delete(int id);
    }
}
