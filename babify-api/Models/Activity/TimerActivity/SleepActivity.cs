using babify_api.Models.TimerActivity;

namespace babify_api.Models.Activity.TimerActivity
{
    public class SleepActivity : ActivityModel
    {
        public int Seconds  { get; set; }
        public DateTime FinishTime { get; set; }
    }
}
