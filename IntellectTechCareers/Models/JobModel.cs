﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntellectTechCareers.Models
{
    public class JobModel
    {
        public int jobId { get; set; }

        [Display(Name = "Job Description")]
        public string JobDesc { get; set; }

        [Display(Name = "Job Role")]
        public int JobRole { get; set; }
        public IEnumerable<JobRole> JobRoles { get; set; }

        [Display(Name = "Skills")]
        public List<string> Skills { get; set; }

        [Display(Name = "Vacancies")]
        public int Vacancies { get; set; }

        [Display(Name = "Min Experience")]
        public int MinExperience { get; set; }

        [Display(Name = "Max Experience")]
        public int MaxExperience { get; set; }

        [Display(Name = "Age Limit")]
        public int AgeLimit { get; set; }

        [Display(Name = "Posted by")]
        public int PostedBy { get; set; }
    }

    public class JobViewModel
    {
        public List<JobModel> jobs  { get; set; }
    }
}