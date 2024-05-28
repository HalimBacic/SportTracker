﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SportActivityAPI.Repository.Models
{
    public partial class Activity
    {
        public Activity()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? Duration { get; set; }
        public int ActivityTypeId { get; set; }

        public virtual Activitytype ActivityType { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}