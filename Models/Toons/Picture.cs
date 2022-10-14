using System.ComponentModel.DataAnnotations;

namespace ApiPool.Models.Toons
{
    public class Picture {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
    }
}