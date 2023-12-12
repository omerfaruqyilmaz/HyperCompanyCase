using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperCompanyCase.Entities.Entity
{
    [Table("Buses")]
    public class Bus : Vehicle
    {
        [StringLength(50)] public string Name { get; set; }
    }
}
