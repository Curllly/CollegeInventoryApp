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
    public class EqipmentTypeIdToName : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = (int)value;

            var matrix = Session.Instance.Context.Matrices.Include(o => o.Equipment).Include(o => o.EquipmentType);
            var matrixItem = matrix.FirstOrDefault(x => x.Id == id);
            if (matrixItem != null)
            {
                return matrixItem.EquipmentType.Name;
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
