using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadDataForms_WPF.Model;
using System.Runtime.CompilerServices;

namespace RadDataForms_WPF.ViewModel
{
    public class MainViewModel
    {

        public ObservableCollection<Patient> GetPatient()
        {
            ObservableCollection<Patient> patient=new ObservableCollection<Patient>();
            patient.Add(new Patient()
            {
                FirstName="Michael",
                LastName="Crump",
                AdmittedOnDate=new DateTime(2013, 04, 12),
                IsCritical=true,
                Weight=200,
                WhatGender=Patient.Gender.Male
            });
            patient.Add(new Patient()
            {
                FirstName="Jane",
                LastName="Simpson",
                AdmittedOnDate=new DateTime(2013, 03, 03),
                IsCritical=true,
                Weight=120,
                WhatGender=Patient.Gender.Female
            });
            patient.Add(new Patient()
            {
                FirstName="John",
                LastName="Peterson",
                AdmittedOnDate=new DateTime(2013, 02, 12),
                IsCritical=false,
                Weight=220,
                WhatGender=Patient.Gender.Male
            });
            patient.Add(new Patient()
            {
                FirstName="Peter",
                LastName="Bush",
                AdmittedOnDate=new DateTime(2013, 01, 12),
                IsCritical=true,
                Weight=175,
                WhatGender=Patient.Gender.Male
            });
            return patient;
        }

    
    }
}