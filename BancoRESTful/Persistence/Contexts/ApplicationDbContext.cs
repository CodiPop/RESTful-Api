﻿using Application.Interface;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {

        private readonly IDateTimeService _dateTime;
        protected ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTimeService dateTime) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Cliente> Clientes { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
   
                    case EntityState.Modified:
                        entry.Entity.Created = _dateTime.NowUtc;
                        break;
                    case EntityState.Added:
                        entry.Entity.LastModified = _dateTime.NowUtc;
                        break;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
