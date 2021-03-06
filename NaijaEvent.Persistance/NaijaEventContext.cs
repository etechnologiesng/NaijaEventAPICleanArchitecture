﻿using Microsoft.EntityFrameworkCore;
using NaijaEvent.Domain;
using NaijaEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Persistance
{
  public  class NaijaEventContext : DbContext
    {


        public NaijaEventContext(DbContextOptions<NaijaEventContext> options)
          : base(options)
        { }
        public DbSet<NEvent> NEvents { get; set; }
    }
}
