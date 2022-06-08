using babify_api.Models.TimerActivity;

namespace babify_api.Models.Activity
{
    public class PumpingActivity : ActivityModel
    {
        public string? PumpingType { get; set; }
        public string? Amount { get; set; }
    }
}
