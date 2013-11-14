﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EHealthCareDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eHealthCareEntities : DbContext
    {
        public eHealthCareEntities()
            : base("name=eHealthCareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AllergyReaction> AllergyReactions { get; set; }
        public DbSet<AllergyType> AllergyTypes { get; set; }
        public DbSet<BloodPressure> BloodPressures { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<DietaryIntake> DietaryIntakes { get; set; }
        public DbSet<Distance> Distances { get; set; }
        public DbSet<Elevation> Elevations { get; set; }
        public DbSet<Height> Heights { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<MedicationDose> MedicationDoses { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationStregth> MedicationStregths { get; set; }
        public DbSet<MedicationTaken> MedicationTakens { get; set; }
        public DbSet<NutritionInfo> NutritionInfos { get; set; }
        public DbSet<PatientNote> PatientNotes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AudioAppointment> AudioAppointments { get; set; }
        public DbSet<Dicom> Dicoms { get; set; }
    }
}