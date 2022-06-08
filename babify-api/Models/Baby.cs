using babify_api.Models.Activity;
using babify_api.Models.Authentication;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace babify_api.Models
{
    public class Baby
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = string.Empty;
        public string? PhotoURL { get; set; }
        public DateTime BirthDay { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int ParentId1 { get; set; }
        public int? ParentId2 { get; set; }

        [JsonIgnore]
        public virtual ICollection<ApplicationUser>? Parents { get; set; }
        [JsonIgnore]
        public ICollection<BottleMilkActivity>? BottleMilkActivities { get; set; }


    }
}
