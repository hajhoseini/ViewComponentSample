namespace ViewComponentSample.Models
{
    public class DailyMessageRepository : IDailyMessageRepository
    {
        private readonly List<DailyMessage> _list = new List<DailyMessage>
        {
            new DailyMessage { Message = "Message 01", IsDefault = true },
            new DailyMessage { Message = "Message 02", IsDefault = false },
        };

        public DailyMessage GetDefault()
        {
            return _list.FirstOrDefault(c => c.IsDefault == true);
        }
    }
}
