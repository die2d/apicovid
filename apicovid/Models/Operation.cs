using System;
using System.Collections.Generic;

namespace apicovid.Models;

public partial class Operation
{
    public int OperationId { get; set; }

    public string? OperationName { get; set; }

    public int? ModuleId { get; set; }

    public virtual Module? Module { get; set; }

    public virtual ICollection<RolOperation> RolOperations { get; } = new List<RolOperation>();
}
