using babify_api.Models.TimerActivity;

namespace babify_api.Models.Activity
{
    public class MeasureActivity : ActivityModel
    {
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? Head { get; set; }
    }
}
