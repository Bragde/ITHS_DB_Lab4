using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.DataAccess.Configurations
{
    class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
