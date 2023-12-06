using CollegeInventory.Commands;
using CollegeInventory.Models;
using CollegeInventory.Views.CRUD.Room;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollegeInventory.ViewModels
{
    public class RoomViewModel : BaseViewModel
    {
        private Room selectedRoom;

        public ObservableCollection<Room> Rooms { get; set; }
        public Room SelectedRoom 
        {
            get { return selectedRoom; }
            set
            {
                selectedRoom = value;
                OnPropertyChanged(nameof(SelectedRoom));
            }
        }
        public RoomViewModel()
        {
            Rooms = new ObservableCollection<Room>(Session.Instance.Context.Rooms);
            EditRoom = new RelayCommand(editRoom, canUse);
            DeleteRoom = new RelayCommand(deleteRoom, canUse);
        }
        // Commands
        public ICommand EditRoom { get; set; }
        public ICommand DeleteRoom { get; set; }
        void editRoom(object obj)
        {
            if (SelectedRoom != null)
            {
                var room = SelectedRoom;
                AddRoomWindow addRoomWindow = new AddRoomWindow(room);
                addRoomWindow.Show();
            }
            else
            {
                MessageBox.Show("Ошибка", "Выберите помещение");
            }
            OnPropertyChanged(nameof(Rooms));
        }
        bool canUse(object obj)
        {
            return PropertyContainer.IsAdmin;
        }
        void deleteRoom(object obj)
        {
            if (SelectedRoom != null)
            {
                var toDeleteRoom = Session.Instance.Context.Rooms.FirstOrDefault(x => x.Id.Equals(SelectedRoom.Id));
                if (toDeleteRoom != null)
                {
                    Session.Instance.Context.Remove(toDeleteRoom);
                    Session.Instance.Context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Ошибка", "Выберите помещение");
            }
            OnPropertyChanged(nameof(Rooms));
        }
    }
}
