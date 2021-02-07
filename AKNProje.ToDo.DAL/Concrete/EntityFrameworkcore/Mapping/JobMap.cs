using AKNProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Mapping
{
    public class JobMap : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(I => I.ID);
            builder.Property(I => I.ID).UseIdentityColumn();
            builder.Property(I => I.Name).HasMaxLength(200).IsRequired();
            builder.Property(I => I.Description).HasMaxLength(300).HasColumnType("ntext");

            builder.HasOne(x => x.Urgency).WithMany(x => x.Jobs).HasForeignKey(x => x.UrgencyId);
            
        }
    }
}
