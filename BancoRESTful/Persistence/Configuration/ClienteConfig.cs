using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public ClienteConfig() { }

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nombre).HasMaxLength(80).IsRequired();

            builder.Property(t => t.Apellido).HasMaxLength(80).IsRequired();

            builder.Property(t => t.FechaNacimiento).IsRequired();

            builder.Property(t => t.Telefono).HasMaxLength(9).IsRequired();

            builder.Property(t => t.Email).HasMaxLength(100);

            builder.Property(t => t.Direccion).HasMaxLength(120).IsRequired();

            builder.Property(t => t.Edad);

            builder.Property(t => t.CreatedBy).HasMaxLength(30);

            builder.Property(t => t.LastModifiedBy).HasMaxLength(30);

        }
    }
}
