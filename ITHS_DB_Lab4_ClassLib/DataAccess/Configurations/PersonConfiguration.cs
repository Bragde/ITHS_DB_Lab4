using ITHS_DB_Lab4_DbModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.DataAccess.Configurations
{
    class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(en => en.FirstName).IsRequired();
            builder.Property(en => en.FirstName).HasMaxLength(255);
            builder.Property(en => en.LastName).IsRequired();
            builder.Property(en => en.LastName).HasMaxLength(255);
        }
    }
}
