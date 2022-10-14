using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPool.Models.Sports
{
public class Player {
    public int PlayerId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Position { get; set; }

    public string TeamName { get; set; }
    
    [ForeignKey("TeamName")] 
    public Team Team { get; set; }
}

}