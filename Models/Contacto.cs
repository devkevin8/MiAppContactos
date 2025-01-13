using System;
using System.Collections.Generic;

namespace MiAppContactos.Models;

public partial class Contacto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string NumeroTelefono { get; set; } = null!;

    public string? Email { get; set; }

    public bool? Activo { get; set; }

    public int IdTipoNumero { get; set; }

    public int IdUsuario { get; set; }

    public virtual TiposNumero IdTipoNumeroNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
