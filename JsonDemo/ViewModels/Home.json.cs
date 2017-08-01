using Starcounter;

namespace JsonDemo
{
    partial class Home : Json
    {
        protected override void OnData()
        {
            base.OnData();
            var obj = new ControllerInput();
            DefaultTemplate.Bind = nameof(obj);
        }
    }
}
