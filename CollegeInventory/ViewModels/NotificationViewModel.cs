using CollegeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInventory.ViewModels
{
    public class NotificationViewModel : BaseViewModel
    {
        public string Icon { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public NotificationViewModel()
        {
            Icon = PropertyContainer.IsAdmin ? "ShieldCrown" : "Alert";
            Heading = PropertyContainer.IsAdmin ? "Режим администратора" : "Гостевой режим";
            Description = PropertyContainer.IsAdmin ? "Вам доступны все функции" : "Некоторые функции могут быть ограничены";
        }
    }
}
