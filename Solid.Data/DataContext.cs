using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
       public DbSet<Employee> employees {  get; set; }  
       public DbSet<Client> clients {  get; set; }  
       public DbSet<Room> rooms {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=Hotel_db\SQLEXPRESS");
        }
      

    }
}
