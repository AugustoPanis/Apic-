using Escola.Aplication.DTOs.Usuario;

namespace Escola.Aplication.Services;

public interface IUsuarioService
{
    Task<UsuarioGetDTO> GetByIdAsync(int Id);
    Task<List<UsuarioGetDTO>> GetAllAsync();
    Task<UsuarioGetDTO> UpdateAsync(UsuarioPutDTO usuario);
    Task<UsuarioGetDTO> AddAsync(UsuarioPostDTO usuario);
    Task<UsuarioGetDTO> DeleteAsync(int Id);
}