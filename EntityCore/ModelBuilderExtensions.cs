using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCore
{
    public static class ModelBuilderExtensions
    {
        public static void BuildCoreSqlModel(this ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(FacilityEntityConfig).Assembly);
        }
    }
}
