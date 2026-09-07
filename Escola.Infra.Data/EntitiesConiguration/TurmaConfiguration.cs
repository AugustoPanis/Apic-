using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.EntitiesConiguration;

public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
{
    public void Configure(EntityTypeBuilder<Turma> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Descricao);
        
        builder.HasOne(t => t.Curso)
            .WithMany(t => t.Turma)
            .HasForeignKey(t => t.IdCurso)
            .OnDelete(DeleteBehavior.NoAction);
    }
}