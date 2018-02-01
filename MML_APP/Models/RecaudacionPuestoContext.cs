using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MML_APP.Models
{
    public class RecaudacionPuestoContext : DbContext
    {
        public DbSet<RecaudacionPuestoModels>RecaudacionPuesto{get;set;}
    }
}