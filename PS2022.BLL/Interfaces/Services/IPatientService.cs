using PS2022.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Interfaces.Services
{
    public interface IPatientService
    {
        public PatientDTO Create(PatientDTO dto);
        public PatientDTO GetById(int id);
        public List<PatientDTO> GetAll();
        public PatientDTO Update(PatientDTO dto);
        public void Delete(int id);
    }
}
