using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.DataAccess.Configurations
{
    class GearConfiguration : IEntityTypeConfiguration<Gear>
    {
        public void Configure(EntityTypeBuilder<Gear> builder)
        {
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
