using PS2022.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Interfaces.Services
{
    public interface IAppointmentService
    {
        public AppointmentDTO Create(AppointmentDTO dto);
        public AppointmentDTO GetById(int id);
        public List<AppointmentDTO> GetAll();
        public AppointmentDTO Update(AppointmentDTO dto);
        public void Delete(int id);
    }
}
