﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace JobApplicationManager.Data
{
    public partial class Company
    {
        public Company()
        {
            JobApplications = new HashSet<JobApplication>();
        }

        public long Id { get; set; }
        public byte[] Name { get; set; }
        public byte[] Street { get; set; }
        public long? Zip { get; set; }
        public byte[] City { get; set; }
        public byte[] Email { get; set; }
        public byte[] Phone { get; set; }
        public byte[] ContactName { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}