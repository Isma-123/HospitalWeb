using HospitalsWeb.cs.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalsWeb.cs.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        // Mapeo de entidades del negocio

        #region Entidades de Citas
        public DbSet<Appointment> Appointments { get; set; }
        #endregion

        #region Entidades de Doctores
        public DbSet<Doctor> Doctors { get; set; }
        #endregion

        #region Entidades de Registros Médicos
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        #endregion

        #region Entidades de Pacientes
        public DbSet<Patient> Patients { get; set; }
        #endregion

        #region Entidades Hospitals
        public DbSet<Hospital> Hospitals { get; set; }
        #endregion



        }
    }
