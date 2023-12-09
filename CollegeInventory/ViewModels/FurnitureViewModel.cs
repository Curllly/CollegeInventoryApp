using CollegeInventory.Models;
using CollegeInventory.Views.CRUD.Equipment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using CollegeInventory.Commands;

namespace CollegeInventory.ViewModels
{
    public class FurnitureViewModel : BaseViewModel
    {
        private Equipment selectedEquipment;
        public ObservableCollection<Equipment> Equipments { get; set; }
        public FurnitureViewModel()
        {
            Equipments = new ObservableCollection<Equipment>(Session.Instance.Context.Equipments
                .Include(x => x.Matrix).ThenInclude(x => x.EquipmentType).ThenInclude(x => x.ObjectType)
                .Where(x => x.Matrix.EquipmentType.ObjectType.Id == 1));
            EditEquipment = new RelayCommand(editEquipment, canUse);
            DeleteEquipment = new RelayCommand(deleteEquipment, canUse);
        }
        public Equipment SelectedEquipment
        {
            get => selectedEquipment;
            set
            {
                selectedEquipment = value;
                OnPropertyChanged(nameof(SelectedEquipment));
            }
        }
        public ICommand EditEquipment { get; set; }
        public ICommand DeleteEquipment { get; set; }
        void editEquipment(object obj)
        {
            if (SelectedEquipment != null)
            {
                var equipment = SelectedEquipment;
                var addEquipmentWindow = new AddEquipmentWindow(equipment);
                addEquipmentWindow.Show();
            }
            else
            {
                MessageBox.Show("Ошибка", "Выберите оборудование");
            }
        }
        void deleteEquipment(object obj)
        {
            if (SelectedEquipment != null)
            {
                var toDeleteEquipment = Session.Instance.Context.Equipments.FirstOrDefault(x => x.Id.Equals(SelectedEquipment.Id));
                if (toDeleteEquipment != null)
                {
                    Session.Instance.Context.Remove(toDeleteEquipment);
                    Session.Instance.Context.SaveChanges();
                }
            }
        }
        bool canUse(object obj)
        {
            return true;
        }
    }
}
