using kurtProje.ToDo.Entities.concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace kurtProje.ToDo.Dataaccess.Concreate.EntityFreamworkCore.Mapping
{
    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Ad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Soyad).HasMaxLength(100).IsRequired(false);
            builder.Property(I => I.Telefon).HasMaxLength(50);
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(I => I.calismalar).WithOne(I => I.Kullanici).HasForeignKey
                (I => I.KullaniciId);






        }
    }
}
