using System;
using System.Collections.Generic;

namespace CollegeInventory.Models;

public partial class Equipment
{
    public int Id { get; set; }

    public int MatrixId { get; set; }

    public int StatusId { get; set; }

    public int InventoryNumber { get; set; }

    public DateOnly PurchaseDate { get; set; }

    public virtual Matrix Matrix { get; set; } = null!;

    public virtual ICollection<RoomsEquipment> RoomsEquipments { get; set; } = new List<RoomsEquipment>();

    public virtual Status Status { get; set; } = null!;
}
