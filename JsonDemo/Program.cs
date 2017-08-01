using Starcounter;

namespace JsonDemo
{
    public class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/jsondemo", (Request request) =>
            {
                if (Session.Current == null)
                {
                    Session.Current = new Session(SessionOptions.PatchVersioning);
                }

                var master = Session.Current.Data as Home;

                if (master == null)
                {
                    master = new Home()
                    {
                        Html = "/JsonDemo/viewmodels/Home.html"
                    };
                    Session.Current.Data = master;
                }

                return master;
            });

            HandlerWrapper.POST("/jsondemo/person", (Person person) =>
            {
                person.Name = "Mihai";
                person.age = 24;
                return HandlerWrapper.GetResponse(person);
            });

            //wrapper method to convert request to any type
            HandlerWrapper.POST("/jsondemo/object", (ControllerInput controllerInput) =>
            {
                //modify some properties
                controllerInput.ScenarioId = 90;
                controllerInput.Reload = true;
                controllerInput.CustomData.CustomPaginate.PageSize = 100;
                //return response to any type
                return HandlerWrapper.GetResponse(controllerInput);
            });
        }
    }
}