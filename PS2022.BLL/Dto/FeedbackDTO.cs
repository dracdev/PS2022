using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.BLL.Dto
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Comment { get; set; }
        public int MarkValue { get; set; }
        public bool IsAnonymous { get; set; }
        public virtual PatientDTO Patient { get; set; }

        public void ValidateForCreation()
        {

        }
        public void ValidateForUpdate()
        {

        }
    }
}
