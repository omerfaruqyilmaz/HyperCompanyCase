using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperCompanyCase.Entities.Entity
{
    [Table("Boats")]
    public class Boat : Vehicle
    {
        [StringLength(50)] public string Name { get; set; }
    }
}
