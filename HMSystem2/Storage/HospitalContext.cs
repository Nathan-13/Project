using System;
using Microsoft.EntityFrameworkCore;
using HMSystem.Storage.EFModels;

namespace HMSystem.Storage
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) {
            // Empty constructor body...
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
    }
}