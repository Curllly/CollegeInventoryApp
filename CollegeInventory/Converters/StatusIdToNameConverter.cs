using CollegeInventory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CollegeInventory.Converters
{
    public class StatusIdToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = (int)value;

            var equipments = Session.Instance.Context.Equipments.Include(o => o.Status);
            var equipment = equipments.FirstOrDefault(x => x.Id == id);
            if (equipment != null)
            {
                return equipment.Status.Name;
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
