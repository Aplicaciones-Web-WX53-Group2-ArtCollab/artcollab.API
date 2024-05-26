using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Model;

public class BaseModel
{
    public int Id {get;set; }

    public int CreatedUser { get; set; }

    public int? UpdatedUser { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

    public DateTime CreatedDate  { get; set; }

    public DateTime? UpdatedDate  { get; set; }
    public Boolean IsActive { get; set; } = true;
}