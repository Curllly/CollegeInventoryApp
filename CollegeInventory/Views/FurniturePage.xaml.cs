using CollegeInventory.Models;
using CollegeInventory.ViewModels;
using CollegeInventory.Views.CRUD.Equipment;
using CollegeInventory.Views.CRUD.Furniture;
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
    /// Логика взаимодействия для FurniturePage.xaml
    /// </summary>
    public partial class FurniturePage : Page
    {
        public FurniturePage()
        {
            InitializeComponent();
            DataContext = new FurnitureViewModel();
        }

        private void AddNewFurniture(object sender, RoutedEventArgs e)
        {
            var furniture = new Equipment();
            var addFurnitureWindow = new AddFurnitureWindow(furniture);
            addFurnitureWindow.Show();
        }
    }
}
