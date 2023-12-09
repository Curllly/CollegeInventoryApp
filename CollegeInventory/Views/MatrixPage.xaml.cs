using CollegeInventory.Models;
using CollegeInventory.ViewModels;
using CollegeInventory.Views.CRUD.Matrix;
using CollegeInventory.Views.CRUD.Room;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollegeInventory.Views
{
    /// <summary>
    /// Логика взаимодействия для MatrixPage.xaml
    /// </summary>
    public partial class MatrixPage : Page
    {
        public MatrixPage()
        {
            InitializeComponent();
            DataContext = new MatrixViewModel();
            if (PropertyContainer.IsAdmin == false)
            {
                addButton.IsEnabled = false;
            }
        }

        private void AddNewMatrix(object sender, RoutedEventArgs e)
        {
            var matrix = new Models.Matrix();
            var addProductWindow = new AddProductWindow(matrix);
            addProductWindow.Show();
        }
    }
}
