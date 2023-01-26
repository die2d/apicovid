﻿using System;
using System.Collections.Generic;

namespace apicovid.Models;

public partial class HistoricUsvalue
{
    public int Id { get; set; }

    public int? Date { get; set; }

    public string? DateChecked { get; set; }

    public int? Death { get; set; }

    public int? DeathIncrease { get; set; }

    public string? Hash { get; set; }

    public int? Hospitalized { get; set; }

    public int? HospitalizedCumulative { get; set; }

    public int? HospitalizedCurrently { get; set; }

    public int? HospitalizedIncrease { get; set; }

    public int? InIcuCumulative { get; set; }

    public int? InIcuCurrently { get; set; }

    public string? LastModified { get; set; }

    public int? Negative { get; set; }

    public int? NegativeIncrease { get; set; }

    public int? OnVentilatorCumulative { get; set; }

    public int? OnVentilatorCurrently { get; set; }

    public int? Pending { get; set; }

    public int? PosNeg { get; set; }

    public int? Positive { get; set; }

    public int? PositiveIncrease { get; set; }

    public int? Recovered { get; set; }

    public int? States { get; set; }

    public int? Total { get; set; }

    public int? TotalTestResults { get; set; }

    public int? TotalTestResultsIncrease { get; set; }
}
