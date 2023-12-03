using System;
using System.Collections.Generic;

namespace CollegeInventory.Models;

public partial class RoomsEquipment
{
    public int Id { get; set; }

    public int RoomId { get; set; }

    public int EquipmentId { get; set; }

    public DateOnly Date { get; set; }

    public virtual Equipment Equipment { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
