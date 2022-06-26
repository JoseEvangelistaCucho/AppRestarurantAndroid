using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRestaurant.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        internal int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordUser { get; set; }
        public string Phone { get; set; }
        public string dni { get; set; }
        public string direction { get; set; }
        public string Tipo { get; set; }

    }
}
