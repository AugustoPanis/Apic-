using Escola.Aplication.DTOs.Matricula;
using Escola.Domain.Interfaces;

namespace Escola.Aplication.Services;

public class MatriculaService : IMatriculaService
{
    private readonly IMatriculaRepository _repository;

    public MatriculaService(IMatriculaRepository repository)
    {
        _repository = repository;
    } 
    
    public async Task<MatriculaGetDTO> GetByIdAsync(int Id)
    {
        var matricula = _repository.GetByIdAsync(Id);
        if (matricula == null)
        {
            return null;
        }

        return new MatriculaGetDTO(
            Id = matricula.Id,
            UsuarioId = matricula.UsuarioId,
        );
    }

    public Task<List<MatriculaGetDTO>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MatriculaGetDTO> UpdateAsync(MatriculaPutDTO matricula)
    {
        throw new NotImplementedException();
    }

    public Task<MatriculaGetDTO> AddAsync(MatriculaPostDTO matricula)
    {
        throw new NotImplementedException();
    }

    public Task<MatriculaGetDTO> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }
}