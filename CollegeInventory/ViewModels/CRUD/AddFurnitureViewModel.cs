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
    public class AddFurnitureViewModel : BaseViewModel
    {
        public Equipment Furniture { get; set; }
        public ObservableCollection<Matrix> Matrices { get; set; }
        public event Action CloseWindowRequested;
        public AddFurnitureViewModel(Equipment furniture)
        {
            Furniture = furniture;
            if (furniture.StatusId == 0)
            {
                Furniture.StatusId = 1;
                Furniture.PurchaseDate = DateOnly.FromDateTime(DateTime.Now);
            }
            Exit = new RelayCommand(exit, canUse);
            AddOrEdit = new RelayCommand(addOrEdit, canUse);
            Matrices = new ObservableCollection<Matrix>(Session.Instance.Context.Matrices
                .Include(x => x.EquipmentType)
                .ThenInclude(x => x.ObjectType)
                .Where(x => x.EquipmentType.ObjectTypeId == 1));
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
            if (Furniture.Id == 0)
            {
                Session.Instance.Context.Add(Furniture);
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
                var furnitureToUpdate = Session.Instance.Context.Equipments.FirstOrDefault(x => x.Id.Equals(Furniture.Id));
                if (furnitureToUpdate != null)
                {
                    Session.Instance.Context.Entry(furnitureToUpdate).State = EntityState.Detached;
                    furnitureToUpdate = Furniture;
                }
                Session.Instance.Context.Entry(furnitureToUpdate).State = EntityState.Modified;
                Session.Instance.Context.Update<Equipment>(furnitureToUpdate);
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
