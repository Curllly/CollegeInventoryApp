using CollegeInventory.Models;
using CollegeInventory.ViewModels;
using CollegeInventory.Views.CRUD.Location;
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
    /// Логика взаимодействия для LocationPage.xaml
    /// </summary>
    public partial class LocationPage : Page
    {
        public LocationPage()
        {
            InitializeComponent();
            DataContext = new LocationViewModel();
        }

        private void addNewLocation(object sender, RoutedEventArgs e)
        {
            var location = new RoomsEquipment();
            var addLocationWindow = new AddLocationWindow(location);
            addLocationWindow.Show();
        }
    }
}
