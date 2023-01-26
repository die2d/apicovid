using System;
using System.Collections.Generic;

namespace apicovid.Models;

public partial class RolOperation
{
    public int RolOperationId { get; set; }

    public int? RolId { get; set; }

    public int? OperationId { get; set; }

    public virtual Operation? Operation { get; set; }

    public virtual Rol? Rol { get; set; }
}
