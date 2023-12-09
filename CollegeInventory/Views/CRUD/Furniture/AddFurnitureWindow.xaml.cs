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

namespace CollegeInventory.Views.CRUD.Furniture
{
    /// <summary>
    /// Логика взаимодействия для AddFurnitureWindow.xaml
    /// </summary>
    public partial class AddFurnitureWindow : Window
    {
        public AddFurnitureWindow(Models.Equipment furniture)
        {
            InitializeComponent();
            DataContext = new AddFurnitureViewModel(furniture);
        }
    }
}
