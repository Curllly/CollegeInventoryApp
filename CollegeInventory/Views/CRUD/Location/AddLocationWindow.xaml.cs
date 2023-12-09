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

namespace CollegeInventory.Views.CRUD.Location
{
    /// <summary>
    /// Логика взаимодействия для AddLocationWindow.xaml
    /// </summary>
    public partial class AddLocationWindow : Window
    {
        public AddLocationWindow(RoomsEquipment? location)
        {
            InitializeComponent();
            var viewModel = new AddLocationViewModel(location);
            viewModel.CloseWindowRequested += CloseWindow;

            DataContext = viewModel;
        }
        private void CloseWindow()
        {
            Close();
        }
    }
}
