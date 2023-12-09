using CollegeInventory.Commands;
using CollegeInventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CollegeInventory.ViewModels.CRUD
{
    public class AddLocationViewModel : BaseViewModel
    {
        private int _inventoryNumber;

        public int InventoryNumber 
        { 
            get => _inventoryNumber;
            set
            {
                _inventoryNumber = value;
                OnPropertyChanged(nameof(InventoryNumber));
            }
        }
        public event Action CloseWindowRequested;
        private Room _room;
        public Room Room 
        {
            get => _room;
            set
            {
                _room = value;
                OnPropertyChanged(nameof(Room));
            }
        }
        public ObservableCollection<Room> Rooms { get; set; }
        public DateOnly LocationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public AddLocationViewModel(RoomsEquipment? location)
        {
            Room = location.Room;
            Exit = new RelayCommand(exit, canUse);
            Rooms = new ObservableCollection<Room>(Session.Instance.Context.Rooms);
            AddOrEdit = new RelayCommand(addOrEdit, canUse);
        }
        public ICommand Exit { get; set; }
        public ICommand AddOrEdit { get; set; }
        void exit(object obj)
        {
            CloseWindowRequested?.Invoke();
        }
        public bool canUse(object obj)
        {
            return true;
        }
        public void addOrEdit(object obj)
        {
            bool isAnyEquipmentExists = Session.Instance.Context.Equipments.Any(x => x.InventoryNumber == InventoryNumber);
            if (isAnyEquipmentExists)
            {
                bool isAnyRoomExists = Session.Instance.Context.Rooms.Any(x => x.Number == Room.Number);
                if (isAnyRoomExists)
                {
                    // Добавление
                    var newEquipment = Session.Instance.Context.Equipments.FirstOrDefault(x => x.InventoryNumber == InventoryNumber);
                    var newRoom = Session.Instance.Context.Rooms.FirstOrDefault(x => x.Number == Room.Number);

                    var newLocation = new RoomsEquipment
                    {
                        Equipment = newEquipment,
                        Room = newRoom,
                        Date = LocationDate

                    };
                    Session.Instance.Context.Add(newLocation);
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
                    MessageBox.Show("Помещения с таким номером не сущестует!");
                }
            }
            else
            {
                MessageBox.Show("Такого материального актива не существует!");
            }
        }
    }
}
