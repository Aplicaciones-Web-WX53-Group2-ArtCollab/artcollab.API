using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Model;

public class Reader : BaseModel
{
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Type { get; set; }
    public string ImgUrl { get; set; }
}