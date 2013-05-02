using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RadDataForms_WPF.Model
{

    
    public class Patient
    {
        [Display(Name = "First Name")]
        [Description("Enter the First Name of the Patient.")]
        public string FirstName
        {
            get;
            set;
        }

        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }

        [Display(Name = "Admitted On")]
        public DateTime AdmittedOnDate
        {
            get;
            set;
        }

        [Display(Name = "Is Critical?")]
        public bool IsCritical
        {
            get;
            set;
        }

        public int Weight
        {
            get;
            set;
        }
        [Display(Name = "Gender")]
        public Gender WhatGender
        {
            get;
            set;
        }

        public enum Gender
        {
            Female,
            Male
        }
    }
}
