using CarManagmentSystem.Models;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarManagmentSystem.MyDatabase
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : DbContext
    {
        public DataContext(): base("MyConnection")
        { 
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<StoresData> storesData { get; set; }
        public DbSet<ServiceData> seriveData { get; set; }
    }
}