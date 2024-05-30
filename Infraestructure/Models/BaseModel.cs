using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.Models;

public class BaseModel
{
    public int Id { get; set; }
    public Boolean IsActive  { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedDate  { get; set; }
    public DateTime? UpdatedDate  { get; set; }
}