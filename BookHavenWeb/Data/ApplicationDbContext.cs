﻿using BookHavenWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookHavenWeb.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public DbSet<Category> Categories { get; set; }
    }
}
