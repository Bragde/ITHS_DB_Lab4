using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.DataAccess.Configurations
{
    class SessionGearConfiguration : IEntityTypeConfiguration<SessionGear>
    {
        public void Configure(EntityTypeBuilder<SessionGear> builder)
        {
            builder.HasKey(s => new { s.SessionId, s.GearId });
        }
    }
}
