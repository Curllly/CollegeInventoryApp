using CollegeInventory.Commands;
using CollegeInventory.Models;
using CollegeInventory.Views.CRUD.Matrix;
using CollegeInventory.Views.CRUD.Room;
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
    public class AddMatrixViewModel : BaseViewModel
    {
        private Matrix editedMatrix;

        public Matrix EditedMatrix 
        { 
            get => editedMatrix;
            set 
            {
                editedMatrix = value;
                OnPropertyChanged(nameof(EditedMatrix));
            }
        }
        public event Action CloseWindowRequested;
        public ObservableCollection<EquipmentType> EquipmentTypes
        {
            get; set;
        }
        public AddMatrixViewModel(Matrix matrix)
        {
            EditedMatrix = matrix;
            EquipmentTypes = new ObservableCollection<EquipmentType>(Session.Instance.Context.EquipmentTypes);
            Exit = new RelayCommand(exit, canUse);
            AddOrEdit = new RelayCommand(addOrEdit, canUse);
        }
        // Commands
        public ICommand Exit { get; set; }
        public ICommand AddOrEdit { get; set; }
        void exit(object obj)
        {
            CloseWindowRequested?.Invoke();
        }
        void addOrEdit(object obj)
        {
            if (EditedMatrix.Id == 0)
            {
                Session.Instance.Context.Add(EditedMatrix);
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
                var matrixToUpdate = Session.Instance.Context.Matrices.FirstOrDefault(x => x.Id.Equals(EditedMatrix.Id));
                if (matrixToUpdate != null)
                {
                    Session.Instance.Context.Entry(matrixToUpdate).State = EntityState.Detached;
                    matrixToUpdate = EditedMatrix;
                }
                Session.Instance.Context.Entry(matrixToUpdate).State = EntityState.Modified;
                Session.Instance.Context.Update<Matrix>(matrixToUpdate);
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
        bool canUse(object obj)
        {
            return true;
        }
    }
}
