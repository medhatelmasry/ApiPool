using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Countries
{
    public class City
    {
        [Key]
        public string CityName { get; set; }


        [Required]
        public int ProvinceId { get; set; }

        [ForeignKey("ProvinceId")] 
        public Province Province { get; set; }
    }
}