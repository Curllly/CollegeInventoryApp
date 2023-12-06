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

namespace CollegeInventory.ViewModels
{
    public class MatrixViewModel : BaseViewModel
    {
        private Matrix selectedMatrix;
        public ObservableCollection<Matrix> Matrices { get; set; }
        public Matrix SelectedMatrix
        {
            get { return selectedMatrix; }
            set
            {
                selectedMatrix = value;
                OnPropertyChanged(nameof(SelectedMatrix));
            }
        }
        public MatrixViewModel()
        {
            Matrices = new ObservableCollection<Matrix>(Session.Instance.Context.Matrices);
            EditMatrix = new RelayCommand(editMatrix, canUse);
            DeleteMatrix = new RelayCommand(deleteMatrix, canUse);
        }
        // Commands
        public ICommand EditMatrix { get; set; }
        public ICommand DeleteMatrix { get; set; }
        void editMatrix(object obj)
        {
            if (SelectedMatrix != null)
            {
                var matrix = SelectedMatrix;
                var addMatrixWindow = new AddProductWindow(matrix);
                addMatrixWindow.Show();
            }
            else
            {
                MessageBox.Show("Ошибка", "Выберите элемент из матрицы");
            }
            OnPropertyChanged(nameof(Matrices));
        }
        bool canUse(object obj)
        {
            return true;
        }
        void deleteMatrix(object obj)
        {
            if (SelectedMatrix != null)
            {
                var toDeleteMatrix = Session.Instance.Context.Matrices.FirstOrDefault(x => x.Id.Equals(SelectedMatrix.Id));
                if (toDeleteMatrix != null)
                {
                    Session.Instance.Context.Remove(toDeleteMatrix);
                    Session.Instance.Context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Ошибка", "Выберите элемент из матрицы");
            }
            OnPropertyChanged(nameof(Matrices));
        }
    }
}
