using System;
using System.Collections.Generic;

namespace CollegeInventory.Models;

public partial class Matrix
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int EquipmentTypeId { get; set; }

    public int Price { get; set; }

    public int ServiceLife { get; set; }

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    public virtual EquipmentType EquipmentType { get; set; } = null!;
}
