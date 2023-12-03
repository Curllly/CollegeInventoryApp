using System;
using System.Collections.Generic;

namespace CollegeInventory.Models;

public partial class EquipmentType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Matrix> Matrices { get; set; } = new List<Matrix>();
}
