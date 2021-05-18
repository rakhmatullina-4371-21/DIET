using System;
using System.Collections.Generic;
using System.Linq;


#nullable disable

namespace DIET
{
    public partial class Patient
    {
        DIET_BDContext db = new DIET_BDContext();

        public int IdPatient { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        Patient patient;

        public Patient ReturnPatient(int? id)
        {
            patient= db.Patients.FirstOrDefault(p => p.IdPatient == id);
            return patient;
        }
        //public Patient(string login, string password)
        //{
        //    Patient patient = db.Patients.FirstOrDefault(u => u.Email == login && u.Password == password);
        //}
        //public Patient PatName() 
        //{
        //    return patient;
        //}

    }
}
