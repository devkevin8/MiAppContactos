using System;
using System.Collections.Generic;

namespace MiAppContactos.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Email { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();
}
