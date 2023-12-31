﻿using CollegeInventory.Models;
using CollegeInventory.ViewModels;
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
    /// Логика взаимодействия для RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        public RoomPage()
        {
            InitializeComponent();
            DataContext = new RoomViewModel();
        }

        private void AddNewRoom(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            AddRoomWindow addRoomWindow = new AddRoomWindow(room);
            addRoomWindow.Show();
        }
    }
}
