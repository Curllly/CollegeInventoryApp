using System;
using System.Collections.Generic;

namespace CollegeInventory.Models;

public partial class Room
{
    public int Id { get; set; }

    public int RoomTypeId { get; set; }

    public int Number { get; set; }

    public string Responsible { get; set; } = null!;

    public string? Information { get; set; }

    public virtual RoomType RoomType { get; set; } = null!;

    public virtual ICollection<RoomsEquipment> RoomsEquipments { get; set; } = new List<RoomsEquipment>();
}
