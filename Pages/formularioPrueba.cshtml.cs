using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class formularioPruebaModel : PageModel
    {
       
        public string namePerson = "Lic. Prueba";
        public string confirmacion = "Si";
        public string telUser = "824-242-2341";

        public List<string> nameClientList = new List<string>
            {
                "prueba1",
                "prueba2",
                "prueba3",
                "prueba4"
            };

        public List<string> timeList = new List<string>
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

        public void OnGet()
        {
            



        }
    }
}
