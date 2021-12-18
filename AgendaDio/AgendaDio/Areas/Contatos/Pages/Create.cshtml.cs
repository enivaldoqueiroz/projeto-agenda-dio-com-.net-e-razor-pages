using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AgendaDio.Areas.Contatos.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaDio.Areas.Contatos.Pages
{
    public class CreateModel : PageModel
    {
        private IWebHostEnvironment _env;

        [BindProperty]
        public Contato Contato { get; set; }

        public CreateModel(IWebHostEnvironment env)
        {
            _env = env;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(CancellationToken cancelationToken)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //salvar a image
            Contato.Id = Guid.NewGuid();
            Contato.FotoUrl = Path.Combine("Images", "Cotatos", $"{Contato.Id} - {Contato.Foto.FileName}");
            var fulPath = Path.Combine(_env.WebRootPath, Contato.FotoUrl);
            using (var fileStream = new FileStream(Contato.FotoUrl, FileMode.Create))
            {
                await Contato.Foto.CopyToAsync(fileStream, cancelationToken);
            }

            //todo: persistir os dados
            return RedirectToPage("Index");
        }
    }
}
