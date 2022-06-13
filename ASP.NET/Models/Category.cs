using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Models; 

public class Category {
    
    [Key]
    public int Id { get; set; }
    [Required]
    public String Name { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}