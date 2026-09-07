using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.EntitiesConiguration;

public class NotaConfiguration : IEntityTypeConfiguration<Nota>
{
    public void Configure(EntityTypeBuilder<Nota> builder)
    {
        builder.HasKey(n => n.Id);
        builder.Property(n => n.ValorNota);
        
        builder.HasOne(n => n.Matricula)
            .WithMany(n => n.Notas)
            .HasForeignKey(n => n.MatriculaId)
            .OnDelete(DeleteBehavior.NoAction);    
    }
}