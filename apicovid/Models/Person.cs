using System;
using System.Collections.Generic;

namespace apicovid.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string PersonName { get; set; } = null!;

    public int RolId { get; set; }

    public string PersonPassword { get; set; } = null!;

    public string PersonUsername { get; set; } = null!;

    public virtual Rol Rol { get; set; } = null!;
}
