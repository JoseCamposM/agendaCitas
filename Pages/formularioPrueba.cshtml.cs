using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class formularioPruebaModel : PageModel
    {
        public string? nameClient { get; set; }
        public string? hora { get; set; }
        public string? asunto { get; set; }
        public string? asignada { get; set; }
        public string? confirmacion { get; set; }
        public string? telefono { get; set; }
        public string mostrar = "no";
      
    public IActionResult OnPost()
    {

        nameClient = Request.Form["nameClient"];
        hora = Request.Form["hora"];
        asunto = Request.Form["asunto"];
        asignada = Request.Form["asignada"];
        confirmacion = Request.Form["confirmacion"];
        telefono = Request.Form["telefono"];
        mostrar = "si";
        return Page();
    }


        public List<string> nameClientList = new List<string>
            {
                "prueba1",
                "prueba2",
                "prueba3",
                "prueba4"
            };

        public List<string> horaList = new List<string>
            {
                "15:30",
                "16:00",
                "16:30",
                "17:00"
            };

        public List<string> asuntoList = new List<string>
            {
                "C-V asdasd as",
                "D qweqweqweqw" ,
                "J zxczxczxc",
                "AFP nbmbnmbnmnb"
            };

        public List<string> confirmacionList = new List<string>
            {
                "si",
                "no",
                "no",
                "si"
            };

        public List<string> licAtenderaList = new List<string>{
            "lic prueba1",
            "lic prueba2",
            "lic prueba3",
            "lic prueba4",
        };

          public List<string> telUserList = new List<string>{
            "824-002-4555",
            "824-000-4555",
            "824-102-0055",
            "824-102-4500",
        };

        public void OnGet()
        {
            



        }
    }
}
