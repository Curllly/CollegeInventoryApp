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
    public class FurnitureViewModel : BaseViewModel
    {
        public ObservableCollection<Equipment> Equipments { get; set; }
        public FurnitureViewModel()
        {
            Equipments = new ObservableCollection<Equipment>(Session.Instance.Context.Equipments
                .Include(x => x.Matrix).ThenInclude(x => x.EquipmentType).ThenInclude(x => x.ObjectType)
                .Where(x => x.Matrix.EquipmentType.ObjectType.Id == 1));
        }
    }
}
