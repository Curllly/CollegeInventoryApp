using CollegeInventory.Commands;
using CollegeInventory.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        }

        // Commands

        public ICommand GoToEquipmentPage { get; set; }
        public ICommand GoToRoomPage { get; set; }

        private bool CanOpenPage(object obj)
        {
            return IsAdmin;
        }

        private void goToEquipmentPage(object obj)
        {
            CurrentPage = new Uri("EquipmentPage.xaml", UriKind.Relative);
        }
        private void goToRoomPage(object obj)
        {
            CurrentPage = new Uri("RoomPage.xaml", UriKind.Relative);
        }
    }
}
