using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.DataAccess.Configurations
{
    class SessionExerciseConfiguration : IEntityTypeConfiguration<SessionExercise>
    {
        public void Configure(EntityTypeBuilder<SessionExercise> builder)
        {
            builder.Property(e => e.PainLevel)
                .HasDefaultValue(5);
        }
    }
}
