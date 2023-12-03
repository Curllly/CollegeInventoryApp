using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInventory.Models
{
    public class Session
    {
        private Session()
        {
            context = new CollegeInventoryContext();
        }
        private static Session? instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }
        private CollegeInventoryContext context;
        public CollegeInventoryContext Context => context;
    }
}
