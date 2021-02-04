using AKNProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Mapping
{
    public class GorevMap : IEntityTypeConfiguration<Gorev>
    {
        public void Configure(EntityTypeBuilder<Gorev> builder)
        {
            builder.HasKey(I => I.ID);
            builder.Property(I => I.ID).UseIdentityColumn();
            builder.Property(I => I.Ad).HasMaxLength(200).IsRequired();
            builder.Property(I => I.Aciklama).HasMaxLength(300).HasColumnType("ntext");

            builder.HasOne(x => x.Aciliyet).WithMany(x => x.Gorevler).HasForeignKey(x => x.AciliyetId);
            
        }
    }
}
