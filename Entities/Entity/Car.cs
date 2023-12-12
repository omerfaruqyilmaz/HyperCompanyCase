using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperCompanyCase.Entities.Entity
{
    [Table("Cars")]
    public class Car : Vehicle
    {
        [StringLength(50)] public string Name { get; set; }
        public int? Wheel { get; set; }
        public bool? HeadLigths { get; set; }
    }
}
