﻿using System;
using System.Xml.Linq;

namespace PP.Library.Models
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public Boolean IsActive { get; set; }
        public String? Name { get; set; }
        public String? LongName { get; set; }
        public int ClientId { get; set; }

        public override string ToString()
        {
            return $"{Name}.{LongName}. {OpenDate}. {ClosedDate}";

        }
    }
}