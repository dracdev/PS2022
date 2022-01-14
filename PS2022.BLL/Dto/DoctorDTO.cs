using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Dto
{
    public class DoctorDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool IsSpecialist { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual UserDTO User { get; set; }

        public void ValidateForCreation()
        {

        }
        public void ValidateForUpdate()
        {

        }

    }
}
