using AKNProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Mapping
{
    public class RaporMap : IEntityTypeConfiguration<Rapor>
    {
        public void Configure(EntityTypeBuilder<Rapor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Tanim).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Detay).HasColumnType("ntext").HasMaxLength(150);



            builder.HasOne(x => x.Gorev).WithMany(x => x.Rapor).HasForeignKey(x => x.GorevId);
        }
    }
}
