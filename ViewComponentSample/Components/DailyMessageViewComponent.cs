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

        public IViewComponentResult Invoke()
        {
            var result = _repository.GetDefault();
            return View(result);
        }
    }
}
