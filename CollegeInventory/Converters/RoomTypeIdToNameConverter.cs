using CollegeInventory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CollegeInventory.Converters
{
    public class RoomTypeIdToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = (int)value;

            var rooms = Session.Instance.Context.Rooms.Include(o => o.RoomType);
            var room = rooms.FirstOrDefault(x => x.Id == id);
            if (room != null)
            {
               return room.RoomType.Name;
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
