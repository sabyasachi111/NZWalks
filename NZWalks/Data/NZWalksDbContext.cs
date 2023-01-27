﻿using Microsoft.EntityFrameworkCore;
using NZWalks.Models.Domain;

namespace NZWalks.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options):base(options)
        {
                
        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> walks { get; set; }

        public  DbSet<WalkDifficulty> WalkDifficulty{get; set; }

    }
}
