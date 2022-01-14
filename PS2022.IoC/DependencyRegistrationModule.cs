using Microsoft.Extensions.DependencyInjection;
using PS2022.BLL.Interfaces.Services;
using PS2022.BLL.Services;
using PS2022.DAL.Interfaces.Repository;
using PS2022.DAL.Models;
using PS2022.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS2022.IoC
{
    public class DependencyRegistrationModule
    {
        public void RegisterDependencies(IServiceCollection services) 
        {
            services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
            services.AddScoped<IGenericRepository<Patient>, GenericRepository<Patient>>();
            services.AddScoped<IGenericRepository<Doctor>, GenericRepository<Doctor>>();
            services.AddScoped<IGenericRepository<Appointment>, GenericRepository<Appointment>>();
            services.AddScoped<IGenericRepository<Feedback>, GenericRepository<Feedback>>();


            services.AddScoped<IPatientService, PatientService>();
        }
    }
}
