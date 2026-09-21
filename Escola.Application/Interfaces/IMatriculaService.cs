using Escola.Aplication.DTOs.Matricula;

namespace Escola.Aplication.Services;

public interface IMatriculaService
{
    Task<MatriculaGetDetailDTO> GetByIdAsync(int Id);
    Task<List<MatriculaGetDetailDTO>> GetAllAsync();
    Task<MatriculaGetDTO> UpdateAsync(MatriculaPutDTO matricula);
    Task<MatriculaGetDTO> AddAsync(MatriculaPostDTO matricula);
    Task<MatriculaGetDTO> DeleteAsync(int Id);
}