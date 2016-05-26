using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Order : Entity
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string E_mail { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public List<Medicine> OrderedMedicines { get; set; }

        public Order()
        {
            OrderedMedicines = new List<Medicine>();
        }
        
    }
}
