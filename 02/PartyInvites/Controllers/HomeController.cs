using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            
            return View(); //При запуске первым обрабатывается метод Index (из за своего названия по умолчанию) и возвращает view по механизму Razor - с соответствующим названием Index
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View(); //Если в строке адреса ...home/RsvpForm, и запрос Get, вызывается этот метод и возвращает view RsvpForm.cshtml
            // адрес вызывается из ссылки на Index.cshtml
        }


        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        { //Если с этой страницы передается Post запрос (а он передается в форме на ней), то запускается перегруженный метод, принимающий параметры типа GuestResponse
            if (ModelState.IsValid) //проверка на валидность модели по параметрам, указанным в файле GuestResponse.cs
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
