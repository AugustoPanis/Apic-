using Escola.Aplication.DTOs.Matricula;

namespace Escola.Aplication.Services;

public interface IMatriculaService
{
    Task<MatriculaGetDTO> GetByIdAsync(int Id);
    Task<List<MatriculaGetDTO>> GetAllAsync();
    Task<MatriculaGetDTO> UpdateAsync(MatriculaPutDTO matricula);
    Task<MatriculaGetDTO> AddAsync(MatriculaPostDTO matricula);
    Task<MatriculaGetDTO> DeleteAsync(int Id);
}