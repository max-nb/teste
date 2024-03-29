﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.Models;

namespace teste.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();

        }

        public DbSet<Financeiro> Financeiro { get; set; }

        public DbSet<teste.Models.Balanco> Balanco { get; set; }
    }
}
