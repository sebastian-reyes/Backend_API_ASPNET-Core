using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Login_CRUD.Models
{
    [Table("PRODUCTOS")]
    public class Productos
    {
        [Key]
        public int id_prod { get; set; }
        public string nombre_prod { get; set; }
        public string desc_prod { get; set; }
        public int stock_min { get; set; }
        public int stock_actual { get; set; }
        public double precio { get; set; }
    }
}
