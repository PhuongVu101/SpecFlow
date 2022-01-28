using System;
using System.Collections.Generic;
using System.Text;
using UniversityManager.Model.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace UniversityManager.Model
{
    public static class ServicesConfiguration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.TryAddScoped<IStudentRepository, StudentRepository>();
        }
    }
}
