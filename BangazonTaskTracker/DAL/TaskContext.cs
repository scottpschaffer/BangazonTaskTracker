using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BangazonTaskTracker.Models;

namespace BangazonTaskTracker.DAL
{
    public class TaskContext : ApplicationDbContext
    {
        public virtual DbSet<Task1>Tasks { get; set; }
    }
}