using CollegeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInventory.ViewModels
{
    public class RoomViewModel : BaseViewModel
    {
        public ObservableCollection<Room> Rooms { get; set; }
        public RoomViewModel()
        {
            Rooms = new ObservableCollection<Room>(Session.Instance.Context.Rooms);
        }
    }
}
