using Escola.Aplication.DTOs.Turma;
using Escola.Domain.Interfaces;

namespace Escola.Aplication.Services;

public class TurmaService : ITurmaService
{
    private readonly ITurmaRepository _turmaRepository;

    public TurmaService(ITurmaRepository turmaRepository)
    {
        _turmaRepository = turmaRepository;
    }
    public async Task<TurmaGetDTO> GetByIdAsync(int Id)
    {
        var turma = await _turmaRepository.GetByIdAsync(Id);
        if (turma == null)
        {
            return null;
        }
        return new TurmaGetDTO
        {
            Id = turma.Id,
            Nome = turma.Nome,
            Descricao = turma.Descricao

        };
    }

    public async Task<List<TurmaGetDTO>> GetAllAsync()
    {
      var turma = await _turmaRepository.GetAllAsync();
      var turmas = new List<TurmaGetDTO>;
      if (turma == null)
      {
          return null;
      }

      foreach (var turma in turma)
      {
          new List<TurmaGetDTO>
      }
    }

    public async Task<TurmaGetDTO> UpdateAsync(TurmaPutDTO turma)
    {
        throw new NotImplementedException();
    }

    public async Task<TurmaGetDTO> AddAsync(TurmaPostDTO turma)
    {
        throw new NotImplementedException();
    }

    public async Task<TurmaGetDTO> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }
}