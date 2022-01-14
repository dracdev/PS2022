using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Dto
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<DoctorDTO> Doctors { get; set; }
        public List<PatientDTO> Patients { get; set; }

        public void ValidateForCreation()
        {

        }

        public void ValidateForUpdate()
        {

        }

    }
}
