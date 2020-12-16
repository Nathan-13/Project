using System;

namespace HMSystem.Storage.EFModels
{
    public class Symptom
    {
        public Guid SymptomId { get; set; }
        public string SymptomName { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
    }
}