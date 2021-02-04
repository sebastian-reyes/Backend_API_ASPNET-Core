using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Login_CRUD.Models
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        public int id_user { get; set; }
        public string ussername { get; set; }
        public string pass { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string correo { get; set; }
    }
}
