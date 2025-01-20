using MiAppContactos.Models;

public interface IUsuariosService{
    Task<List<Usuario>> GetUsuarios();
    Task<Usuario> GetUsuario(int id);
    Task<Usuario> AddUsuario(Usuario usuario);
    Task<Usuario> UpdateUsuario(Usuario usuario);
    Task<bool> DeleteUsuario(int id);
}