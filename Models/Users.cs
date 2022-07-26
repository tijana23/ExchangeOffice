using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Models
{
    public class Users
    {
        public int UsersId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        public int IsActive { get; set; }
        public ICollection<Operations> Operations { get; set; }
    }
}
