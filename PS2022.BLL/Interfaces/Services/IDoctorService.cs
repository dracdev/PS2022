using PS2022.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Interfaces.Services
{
    public interface IDoctorService
    {
        public DoctorDTO Create(DoctorDTO dto);
        public DoctorDTO GetById(int id);
        public List<DoctorDTO> GetAll();
        public DoctorDTO Update(DoctorDTO dto);
        public void Delete(int id);
    }
}
