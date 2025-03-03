using MiAppContactos.Models;

namespace MiAppContactos.DTOs
{
    public class GetContactosDTO
    {
        /*
        public GetContactosDTO(Contacto contacto)
        {
            Id = contacto.Id;
            Nombre = contacto.Nombre;
            Apellido = contacto.Apellido;
            Telefono = contacto.NumeroTelefono;
            TiposNumeroNombre = contacto.TiposNumero.Nombre;
        }
        */
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string TiposNumeroNombre { get; set; }
        public string UsuarioNombre { get; set; }
    }
}