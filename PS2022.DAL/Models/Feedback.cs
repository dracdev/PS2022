using System;
using System.Collections.Generic;

#nullable disable

namespace PS2022.DAL.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Comment { get; set; }
        public int MarkValue { get; set; }
        public bool IsAnonymous { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
