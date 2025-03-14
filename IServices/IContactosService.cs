using MiAppContactos.DTOs;
using MiAppContactos.Models;

public interface IContactosService
{
    Task<List<GetContactosDTO>> GetContactos();
    Task<Contacto> GetContacto(int id);
    Task<Contacto> AddContacto(Contacto contacto);
    Task<Contacto> UpdateContacto(Contacto contacto);
    Task<bool> DeleteContacto(int id);
}