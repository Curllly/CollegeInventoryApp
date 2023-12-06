using CollegeInventory.Models;
using CollegeInventory.ViewModels;
using CollegeInventory.Views.CRUD.Equipment;
using CollegeInventory.Views.CRUD.Matrix;
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
    /// Логика взаимодействия для EquipmentPage.xaml
    /// </summary>
    public partial class EquipmentPage : Page
    {
        public EquipmentPage()
        {
            InitializeComponent();
            DataContext = new EquipmentViewModel();
        }
        private void AddNewEquipment(object sender, RoutedEventArgs e)
        {
            var equipment = new Equipment();
            var addEquipmentWindow = new AddEquipmentWindow(equipment);
            addEquipmentWindow.Show();
        }
    }
}
