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
    public class MatrixViewModel : BaseViewModel
    {
        public ObservableCollection<Matrix> Matrix { get; set; }
        public MatrixViewModel()
        {
            Matrix = new ObservableCollection<Matrix>(Session.Instance.Context.Matrices);
        }
    }
}
