using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models.DB
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Edad { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
