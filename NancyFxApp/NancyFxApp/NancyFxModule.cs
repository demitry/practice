using Nancy;

namespace NancyFxApp
{
    public class NancyFxModule: NancyModule
    {
        public NancyFxModule()
        {
            Get["/"] = param => View["Index.html"];

            Get["/{Name}"] = param =>
            {
                dynamic viewBag = new DynamicDictionary();
                viewBag.Name = param.Name;
                return View["Hello.html", viewBag];

                /*В NancyFx использует по умолчанию Super Simple View Engine. В отличие от Razor она не поддерживает ViewBag и мы имитируем VieBag добавлением DinamicDictionary, с последующим добавлением оного во ViewModel. При желании можно подключить пакет Razor и пользоваться всеми преимуществами именно это привычного графического движка*/
            };
        }
    }
}