using MiAppContactos.Models;

public interface ITiposNumerosService
{
    Task<List<TiposNumero>> GetTiposNumeros();
    Task<TiposNumero> GetTiposNumero(int id);
    Task<TiposNumero> AddTiposNumero(TiposNumero tiposNumero);
    Task<TiposNumero> UpdateTiposNumero(TiposNumero tiposNumero);
    Task<bool> DeleteTiposNumero(int id);
}