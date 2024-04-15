using Microsoft.AspNetCore.Mvc;
using ViewComponentSample.Models;

namespace ViewComponentSample.Components
{
    public class DailyMessageViewComponent : ViewComponent
    {
        private readonly IDailyMessageRepository _repository;

        public DailyMessageViewComponent(IDailyMessageRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(bool showDefault, string appendText)
        {
            var result = _repository.GetDefault();

            if (showDefault)
                result.Message = $" {result.Message} - {appendText}";

            return View(result);
        }
    }
}
