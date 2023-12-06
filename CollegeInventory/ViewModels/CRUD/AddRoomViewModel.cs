using CollegeInventory.Commands;
using CollegeInventory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollegeInventory.ViewModels.CRUD
{
    public class AddRoomViewModel : BaseViewModel
    {
        public event Action CloseWindowRequested;
        public ObservableCollection<RoomType> RoomTypes
        {
            get; set;
        }
        private Room room;

        // Properties
        public Room Room
        {
            get { return room; }
            set
            {
                room = value;
                OnPropertyChanged(nameof(Room));
            }
        }
        

        public AddRoomViewModel(Room room)
        {
            Room = room;
            RoomTypes = new ObservableCollection<RoomType>(Session.Instance.Context.RoomTypes);
            Exit = new RelayCommand(exit, canUse);
            AddOrEdit = new RelayCommand(addOrEdit, canUse);
        }

        // Commands
        public ICommand Exit { get; set; }
        public ICommand AddOrEdit { get; set; }
        void addOrEdit(object obj)
        {
            if (Room.Id == 0)
            {
                Session.Instance.Context.Add(Room);
                try
                {
                    Session.Instance.Context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error", "Ошибка сохранения, попробуйте ещё раз");
                }
            }
            else
            {
                var roomToUpdate = Session.Instance.Context.Rooms.FirstOrDefault(x => x.Id.Equals(Room.Id));
                if (roomToUpdate != null)
                {
                    Session.Instance.Context.Entry(roomToUpdate).State = EntityState.Detached;
                    roomToUpdate = Room;
                }
                Session.Instance.Context.Entry(roomToUpdate).State = EntityState.Modified;
                Session.Instance.Context.Update<Room>(roomToUpdate);
                try
                {
                    Session.Instance.Context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error", "Ошибка сохранения, попробуйте ещё раз");
                }

            }
            CloseWindowRequested?.Invoke();
        }
        void exit(object obj)
        {
            CloseWindowRequested?.Invoke();
        }
        bool canUse(object obj)
        {
            return true;
        }
        public void CloseWindow()
        {
            CloseWindowRequested?.Invoke();
        }
    }
}
