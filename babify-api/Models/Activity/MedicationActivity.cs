using babify_api.Models.TimerActivity;

namespace babify_api.Models.Activity
{
    public class MedicationActivity : ActivityModel
    {
        public string Name { get; set; }
        public string Dose { get; set; }
    }
}
