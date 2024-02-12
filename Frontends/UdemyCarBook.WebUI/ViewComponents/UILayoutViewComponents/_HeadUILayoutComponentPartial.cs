using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _HeadUILayoutComponentPartial:ViewComponent
    {
        //ViewComponenet Asp.net Core ile geldi
        //Bununla partiallar daha kullanışlı ve daha güvenli bir yöntem oluyor.
        public IViewComponentResult Invoke()
        {
            //Partiallara url üzerinden doğrudan erişim oluyordu
            //ViewComponentlerde bu durum söz konusu değil.
            return View();
        }
    }
}
