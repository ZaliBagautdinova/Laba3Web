using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcceptanceCommission.Models
{
    public class AScontext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}