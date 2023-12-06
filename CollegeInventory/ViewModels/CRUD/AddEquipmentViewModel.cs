using CollegeInventory.Commands;
using CollegeInventory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollegeInventory.ViewModels.CRUD
{
    public class AddEquipmentViewModel
    {
        public Equipment Equipment { get; set; }
        public ObservableCollection<Matrix> Matrices { get; set; }
        public event Action CloseWindowRequested;
        public AddEquipmentViewModel(Equipment equipment)
        {
            Equipment = equipment;
            if (equipment.PurchaseDate == null)
            {
                Equipment.PurchaseDate = DateOnly.FromDateTime(DateTime.Now);
            }
            if (equipment.StatusId != 1)
            {
                Equipment.StatusId = 1;
            }
            Matrices = new ObservableCollection<Matrix>(Session.Instance.Context.Matrices);
            Exit = new RelayCommand(exit, canUse);
            AddOrEdit = new RelayCommand(addOrEdit, canUse);
        }
        public ICommand Exit { get; set; }
        public ICommand AddOrEdit { get; set; }
        void exit(object obj)
        {
            CloseWindowRequested?.Invoke();
        }
        bool canUse(object obj)
        {
            return true;
        }
        void addOrEdit(object obj)
        {
            if (Equipment.Id == 0)
            {
                Session.Instance.Context.Add(Equipment);
                try
                {
                    Session.Instance.Context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error", "Ошибка сохранения, попробуйте ещё раз");
                }
            }
            else
            {
                var equipmentToUpdate = Session.Instance.Context.Equipments.FirstOrDefault(x => x.Id.Equals(Equipment.Id));
                if (equipmentToUpdate != null)
                {
                    Session.Instance.Context.Entry(equipmentToUpdate).State = EntityState.Detached;
                    equipmentToUpdate = Equipment;
                }
                Session.Instance.Context.Entry(equipmentToUpdate).State = EntityState.Modified;
                Session.Instance.Context.Update<Equipment>(equipmentToUpdate);
                try
                {
                    Session.Instance.Context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error", "Ошибка сохранения, попробуйте ещё раз");
                }
            }
        }
    }
}
