using System;
using System.Collections.Generic;

namespace apicovid.Models;

public partial class Rol
{
    public int RolId { get; set; }

    public string RolName { get; set; } = null!;

    public virtual ICollection<Person> People { get; } = new List<Person>();

    public virtual ICollection<RolOperation> RolOperations { get; } = new List<RolOperation>();
}
