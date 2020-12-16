using System;
using System.Collections;

namespace HMSystem.Models
{
    public class Symptom : IEnumerable
    {
        
        // Data members
        public Guid SymptomId { get; set; }
        public string SymptomName { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }

         public IEnumerator GetEnumerator() {
            foreach(var sym in Doctor.Symptoms) {
                yield return sym;
            }
        }
        
    }
}