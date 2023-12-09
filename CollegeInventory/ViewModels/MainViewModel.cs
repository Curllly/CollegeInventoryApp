using CollegeInventory.Commands;
using CollegeInventory.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace CollegeInventory.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        // Properties

        private bool _IsAdmin;

        public  bool IsAdmin
        {
            get { return _IsAdmin; }
        }
        private Uri _CurrentPage;

        public Uri CurrentPage
        {
            get { return _CurrentPage; }
            set 
            {
                _CurrentPage = value; 
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public MainViewModel(bool isAdmin)
        {
            _IsAdmin = isAdmin;
            CurrentPage = new Uri("NotificationPage.xaml", UriKind.Relative);

            GoToEquipmentPage = new RelayCommand(goToEquipmentPage, CanOpenPage);
            GoToRoomPage = new RelayCommand(goToRoomPage, CanOpenPage);
            GoToFurniturePage = new RelayCommand(goToFurniturePage, CanOpenPage);
            GoToMatrixPage = new RelayCommand(goToMatrixPage, AlwaysCan);
            GoToLocationPage = new RelayCommand(goToLocationPage, AlwaysCan);
            GoToHistoryPage = new RelayCommand(goToHistoryPage, CanOpenPage);
            ExitApplication = new RelayCommand(Exit, AlwaysCan);
        }

        // Commands

        public ICommand GoToEquipmentPage { get; set; }
        public ICommand GoToRoomPage { get; set; }
        public ICommand GoToFurniturePage { get; set; }
        public ICommand GoToMatrixPage { get; set; }
        public ICommand GoToLocationPage { get; set; }
        public ICommand GoToHistoryPage { get; set; }
        public ICommand ExitApplication { get; set; }

        private bool CanOpenPage(object obj)
        {
            return IsAdmin;
        }
        private bool AlwaysCan(object obj)
        {
            return true;
        }
        private void Exit(object obj)
        {
            Application.Current.Shutdown();
        }

        private void goToEquipmentPage(object obj)
        {
            CurrentPage = new Uri("EquipmentPage.xaml", UriKind.Relative);
        }
        private void goToRoomPage(object obj)
        {
            CurrentPage = new Uri("RoomPage.xaml", UriKind.Relative);
        }
        private void goToFurniturePage(object obj)
        {
            CurrentPage = new Uri("FurniturePage.xaml", UriKind.Relative);
        }
        private void goToMatrixPage(object obj)
        {
            CurrentPage = new Uri("MatrixPage.xaml", UriKind.Relative);
        }
        private void goToLocationPage(object obj)
        {
            CurrentPage = new Uri("LocationPage.xaml", UriKind.Relative);
        }
        private void goToHistoryPage(object obj)
        {
            CurrentPage = new Uri("HistoryPage.xaml", UriKind.Relative);
        }
    }
}
