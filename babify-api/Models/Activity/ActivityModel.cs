using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace babify_api.Models.TimerActivity
{
    public class ActivityModel
    {

        [Key]
        public int ActivityId { get; set; }
        public int BabyId { get; set; }
        public DateTime StartTime { get; set; }
        public string? Note { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string? Type { get; set; }




    }
}
