using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Persona
    {
        [Key]
        public int id{ get; set;}

        public string nombre { get; set; }

        public int edad { get; set; }
    }
}
