using System;
using System.Collections.Generic;

namespace CollegeInventory.Models;

public partial class ObjectType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EquipmentType> EquipmentTypes { get; set; } = new List<EquipmentType>();
}
