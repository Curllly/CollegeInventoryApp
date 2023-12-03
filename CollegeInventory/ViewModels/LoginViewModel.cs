using CollegeInventory.Commands;
using CollegeInventory.Models;
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
using System.Windows.Input;

namespace CollegeInventory.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        // Properties
        private bool _IsGuest;
        public bool IsGuest
        {
            get { return _IsGuest; }
            set
            {
                _IsGuest = value;
                OnPropertyChanged(nameof(IsGuest));
            }
        }
        private string? _PIN;

        public string PIN
        {
            get { return _PIN!; }
            set 
            {
                _PIN = value;
                OnPropertyChanged(nameof(PIN));
            }
        }

        // Commands
        public ICommand GoToMainWindow { get; set; }
        public LoginViewModel()
        {
            GoToMainWindow = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            if (!IsGuest && PIN == "0000")
            {
                var mainWindow = new MainWindow(true);
                PropertyContainer.IsAdmin = true;
                Application.Current.MainWindow.Close();
                mainWindow.Show();
            }
            else if (!IsGuest && PIN != "0000")
            {
                MessageBox.Show("ОК", "Неверный PIN!");
            }
            else if (IsGuest)
            {
                var mainWindow = new MainWindow(false);
                Application.Current.MainWindow.Close();
                mainWindow.Show();
            }
            
        }
    }
}
