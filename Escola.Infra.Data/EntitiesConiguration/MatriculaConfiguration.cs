using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.EntitiesConiguration;

public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.UsuarioId).IsRequired();
        builder.Property(m => m.TurmaId).IsRequired();
        
        builder.HasOne(x =>  x.Usuario)
            .WithMany(m => m.Matriculas)
            .HasForeignKey(m => m.UsuarioId)
            .OnDelete(DeleteBehavior.NoAction);    
        
        builder.HasOne(x =>  x.Turma)
            .WithMany(m => m.Matriculas)
            .HasForeignKey(m => m.TurmaId)
            .OnDelete(DeleteBehavior.NoAction);
        
    }
}   