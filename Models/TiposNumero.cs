using System;
using System.Collections.Generic;

namespace MiAppContactos.Models;

public partial class TiposNumero
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();
}
