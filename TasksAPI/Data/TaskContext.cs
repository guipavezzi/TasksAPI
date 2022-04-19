using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TasksAPI.Models;

namespace TasksAPI.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> opt) : base(opt)
        {

        }

        public DbSet<Task> Task { get; set; }
    }
}
