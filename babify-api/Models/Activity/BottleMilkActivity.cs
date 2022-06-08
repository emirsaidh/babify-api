using babify_api.Models.TimerActivity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace babify_api.Models.Activity
{
    public class BottleMilkActivity : ActivityModel
    {
        public string? BottleMilkType { get; set; }
        public string? Amount { get; set; }
    }
}
