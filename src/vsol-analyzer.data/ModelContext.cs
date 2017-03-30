using System;
using System.Collections.Generic;
using System.Data.Entity;
using vsol_analyzer.data.Model;

namespace vsol_analyzer.data
{
    class ModelContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<TeamGameStatistics> GameStatistics { get; set; }
    }
}
