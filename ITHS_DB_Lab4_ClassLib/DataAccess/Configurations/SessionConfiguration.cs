using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.DataAccess.Configurations
{
    class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(en => en.Name).IsRequired();
            builder.Property(en => en.Description).IsRequired();
            builder.Property(en => en.Time).IsRequired();
        }
    }
}
