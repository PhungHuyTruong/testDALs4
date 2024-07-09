using System;
using System.Collections.Generic;

namespace DALs4.Models;

public partial class Congty
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string? Diachi { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
