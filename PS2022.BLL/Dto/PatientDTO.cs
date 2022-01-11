using PS2022.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Dto
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User User { get; set; }

        public void ValidateForCreation()
        {

        }
        public void ValidateForUpdate()
        {

        }

        #region Methods
        #endregion
    }
}
