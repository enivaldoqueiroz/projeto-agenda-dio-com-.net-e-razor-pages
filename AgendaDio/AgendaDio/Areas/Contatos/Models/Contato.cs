using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDio.Areas.Contatos.Models
{
    public class Contato
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string FotoUrl { get; set; }
        [NotMapped]
        public IFormFile Foto { get; set; }
    }
}
