using babify_api.Models.TimerActivity;

namespace babify_api.Models.Activity.TimerActivity
{
    public class TummyActivity : ActivityModel
    {
        public int Seconds { get; set; }
        public DateTime FinishTime { get; set; }
    }
}
