using System;
using System.Collections.Generic;

namespace apicovid.Models;

public partial class Module
{
    public int ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;

    public virtual ICollection<Operation> Operations { get; } = new List<Operation>();
}
