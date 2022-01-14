using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Dto
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationMin { get; set; }

        public virtual DoctorDTO Doctor { get; set; }
        public virtual PatientDTO Patient { get; set; }

        public void ValidateForCreation()
        {

        }
        public void ValidateForUpdate()
        {

        }
    }
}
