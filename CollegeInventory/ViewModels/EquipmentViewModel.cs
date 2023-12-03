using CollegeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInventory.ViewModels
{
    public class EquipmentViewModel : BaseViewModel
    {
        public ObservableCollection<Equipment> Equipments { get; set; }
        public EquipmentViewModel()
        {
            Equipments = new ObservableCollection<Equipment>(Session.Instance.Context.Equipments);
        }
    }
}
