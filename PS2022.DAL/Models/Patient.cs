﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PS2022.DAL.Models
{
    public partial class Patient
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User User { get; set; }
    }
}
