using AKNProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Mapping
{
    public class AciliyetMapping : IEntityTypeConfiguration<Aciliyet>
    {
        public void Configure(EntityTypeBuilder<Aciliyet> builder)
        {
            builder.Property(x => x.Tanim).HasMaxLength(100);
            
        }
    }
}
