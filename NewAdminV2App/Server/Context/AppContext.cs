using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAdminV2App.Server.Context
{
    public class AppContext : DbContext
    {
        public AppContext()
        { }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }
    }
}
