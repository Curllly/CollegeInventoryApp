using CollegeInventory.Models;
using CollegeInventory.ViewModels.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CollegeInventory.Views.CRUD.Matrix
{
    /// <summary>
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow(Models.Matrix? matrix)
        {
            InitializeComponent();
            var viewModel = new AddMatrixViewModel(matrix);
            viewModel.CloseWindowRequested += CloseWindow;

            DataContext = viewModel;
        }
        private void CloseWindow()
        {
            Close();
        }
    }
}
