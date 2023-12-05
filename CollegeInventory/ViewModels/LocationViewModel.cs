using CollegeInventory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInventory.ViewModels
{
    public class LocationViewModel : BaseViewModel
    {
        public ObservableCollection<RoomsEquipment> Locations { get; set; }
        public LocationViewModel()
        {
            Locations = new ObservableCollection<RoomsEquipment>(Session.Instance.Context.RoomsEquipments
                .Include(x => x.Equipment)
                .ThenInclude(x => x.Matrix)
                .ThenInclude(x => x.EquipmentType)
                .Include(x => x.Room)
                .ThenInclude(x => x.RoomType));
        }
    }
}
