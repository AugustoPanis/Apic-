using Escola.Aplication.DTOs.Matricula;
using Escola.Aplication.DTOs.Turma;
using Escola.Aplication.DTOs.Usuario;
using Escola.Domain.Interfaces;

namespace Escola.Aplication.Services;

public class MatriculaService : IMatriculaService
{
    private readonly IMatriculaRepository _matriculaRepository;

    public MatriculaService(IMatriculaRepository repository)
    {
        _matriculaRepository = repository;
    } 
    
    public async Task<MatriculaGetDetailDTO> GetByIdAsync(int Id)
    {
        var matricula = await _matriculaRepository.GetByIdAsync(Id);
        if (matricula == null)
        {
            return null;
        }
        return new MatriculaGetDetailDTO
        {
            Id = matricula.Id,
            DataMatricula = matricula.DataMatricula,
            DataExpiracao = matricula.DataExpiracao,
            Ativo = matricula.Ativo,
            Usuario = new UsuarioGetDTO
            {
                Id = matricula.Id,
                nome = matricula.Usuario.Nome,
                Email = matricula.Usuario.Email
            },
            Turma =  new TurmaGetDTO
            {
                Id = matricula.Turma.Id,
                Nome = matricula.Turma.Nome,
                Descricao = matricula.Turma.Descricao,
            }
                
        };
    }

    public Task<List<MatriculaGetDetailDTO>> GetAllAsync()
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