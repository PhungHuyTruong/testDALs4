﻿using System;
using System.Collections.Generic;

namespace DALs4.Models;

public partial class Cuahang
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string Mota { get; set; } = null!;

    public string? Loaihang { get; set; }

    public DateOnly? Ngaydangky { get; set; }

    public int? IdCn { get; set; }

    public virtual Trungtam? IdCnNavigation { get; set; }
}
